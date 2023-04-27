using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morpion
{
    public partial class Form1 : Form
    {

        int caseRemplie;
        private char [] tabMorpion = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };


        public Form1()
        {
            InitializeComponent();
            activateGame();

        }

        private void replay_Click(object sender, EventArgs e)
        {
            resetDisplay();
            activateGame();
        }

        private void resetDisplay()
        {
            case0.Text = "-";
            case1.Text = "-";
            case2.Text = "-";
            case3.Text = "-";   
            case4.Text = "-";
            case5.Text = "-";
            case6.Text = "-";
            case7.Text = "-";
            case8.Text = "-";
            errorLabel.Text = string.Empty;

        }

        int nbreVictoire = 0;
        int nbreDefaite = 0;
        int nbreEgalite = 0;

        private void case_click(object sender, EventArgs e)
        {
            Label senderbutton = (Label)sender;

            char etat = gameStateCheck();
            if (etat == 'c')
            {
                do
                {
                    if (senderbutton.Text != "-")
                    {
                        errorLabel.Text = "Case occupé";

                    }
                    else
                    {
                        errorLabel.Text = string.Empty;
                        senderbutton.Text = "X";
                        string caseRemplieText = senderbutton.Name.Substring(4);
                        caseRemplie = int.Parse(caseRemplieText);
                        tabMorpion[caseRemplie] = 'X';
                        //senderbutton.Enabled = false;
                    }

                } while (senderbutton.Text == "-");
            }

            etat = gameStateCheck();

            if (etat=='c')
            {
                iaPlay();
                etat = gameStateCheck();
                if (etat == 'd')
                {
                    nbreEgalite++;
                    int tmp = int.Parse(nombreEgalite.Text);
                    tmp++;
                    nombreEgalite.Text = tmp.ToString();
                    errorLabel.Text = "egalité";
                    freeTab();
                    disableGame();
                }
                else if (etat == 'X')
                {
                    nbreVictoire++;
                    int tmp = int.Parse(nombreVictoire.Text);
                    tmp++;
                    nombreVictoire.Text = tmp.ToString();
                    errorLabel.Text = "Victoire";
                    freeTab();
                    disableGame();
                }
                else if (etat == 'O')
                {
                    nbreDefaite++;
                    int tmp = int.Parse(nombreDefaite.Text);
                    tmp++;
                    nombreDefaite.Text = tmp.ToString();
                    errorLabel.Text = "defaite";
                    freeTab();
                    disableGame();
                }
            }
            else if (etat == 'd')
            {
                nbreEgalite++;
                int tmp = int.Parse(nombreEgalite.Text);
                tmp++;
                nombreEgalite.Text = tmp.ToString();
                errorLabel.Text = "egalité";
                freeTab();
                disableGame();
            }
            else if (etat == 'X')
            {
                nbreVictoire++;
                int tmp = int.Parse(nombreVictoire.Text);
                tmp++;
                nombreVictoire.Text = tmp.ToString();
                errorLabel.Text = "Victoire";
                freeTab(); 
                disableGame();
            }
            else if (etat == 'O')
            {
                nbreDefaite++;
                int tmp = int.Parse(nombreDefaite.Text);
                tmp++;
                nombreDefaite.Text = tmp.ToString();
                errorLabel.Text = "defaite";
                freeTab();
                disableGame();
            }

        }

        private void freeTab()
        {
            for(int i = 0; i < 9; i++)
            {
                tabMorpion[i] = ' ';
            }

        }

        private char isGameWin()
        {
            char iswin;
            if ((tabMorpion[0] == tabMorpion[1]) && (tabMorpion[1] == tabMorpion[2]))
            {
                iswin = tabMorpion[0];
            }
            else if ((tabMorpion[3] == tabMorpion[4]) && (tabMorpion[4] == tabMorpion[5]))
            {
                iswin = tabMorpion[3];
            }
            else if ((tabMorpion[6] == tabMorpion[7]) && (tabMorpion[7] == tabMorpion[8]))
            {
                iswin = tabMorpion[6];
            }
            else if ((tabMorpion[0] == tabMorpion[4]) && (tabMorpion[4] == tabMorpion[8]))
            {
                iswin = tabMorpion[0];
            }
            else if ((tabMorpion[6] == tabMorpion[4]) && (tabMorpion[4] == tabMorpion[2]))
            {
                iswin = tabMorpion[6];
            }
            else if ((tabMorpion[0] == tabMorpion[3]) && (tabMorpion[3] == tabMorpion[6]))
            {
                iswin = tabMorpion[0];
            }
            else if ((tabMorpion[1] == tabMorpion[4]) && (tabMorpion[4] == tabMorpion[7]))
            {
                iswin = tabMorpion[1];
            }
            else if ((tabMorpion[2] == tabMorpion[5]) && (tabMorpion[5] == tabMorpion[8]))
            {
                iswin = tabMorpion[2];
            }
            else
            {
                iswin = 'c';
            }
            return iswin;
        }

        bool isGameOver()
        {
            bool res = true;
            for (int i=0; i < 9; i++)
            {
                if (tabMorpion[i] == ' ')
                {
                    res = false;
                }
            }
            return res;
        }

        char gameStateCheck()
        {
            char res='c';
            if (isGameWin() == 'c')
            {
                res = 'c';

                if (isGameOver())
                {
                    res = 'd';
                }
            }
            else if (isGameWin() == 'X' || isGameWin() == 'O')
            {
                res = isGameWin();
            }
            return res;
        }

        void isCenterFree()
        {
            if (tabMorpion[4] == ' ')
            {
                tabMorpion[4] = 'O';
                case4.Text = "O";
            }
        }

        private void iaRandomPlay()
        {
            Random rnd = new Random();
            int randomNB = -1;
            do
            {
                randomNB = rnd.Next(9);
                if (tabMorpion[randomNB] == '-')
                {
                    tabMorpion[randomNB] = 'O';

                
                    switch (randomNB)
                    {
                        case 0:
                            case0.Text = "O";
                            break;
                        case 1:
                            case1.Text = "O";
                            break;
                        case 2:
                            case2.Text = "O";
                            break;          
                        case 3:
                            case3.Text = "O";   
                            break;
                        case 4:
                            case4.Text= "O";
                            break;
                        case 5:
                            case5.Text= "O";
                            break;
                        case 6: 
                            case6.Text= "O";
                            break;
                        case 7:
                            case7.Text= "O";
                            break;
                        case 8:
                            case8.Text= "O";
                            break;
                    }
                }


            } while (tabMorpion[randomNB] != 'O');
        }

        void iaPlayToWin()
        {
            if (tabMorpion[0] == tabMorpion[1] && tabMorpion[2] == ' ' && tabMorpion[0] == 'O')
            {
                tabMorpion[2] = 'O';
                case2.Text = "O";
            }
            else if (tabMorpion[1] == tabMorpion[2] && tabMorpion[0] == ' ' && tabMorpion[1] == 'O')
            {
                tabMorpion[0] = 'O';
                case0.Text = "O";
            }
            else if (tabMorpion[0] == tabMorpion[2] && tabMorpion[1] == ' ' && tabMorpion[0] == 'O')
            {
                tabMorpion[1] = 'O';
                case1.Text = "O";

            }
            else if (tabMorpion[3] == tabMorpion[4] && tabMorpion[5] == ' ' && tabMorpion[3] == 'O')
            {
                tabMorpion[5] = 'O';
                case5.Text = "O";
            }
            else if (tabMorpion[4] == tabMorpion[5] && tabMorpion[3] == ' ' && tabMorpion[4] == 'O')
            {
                tabMorpion[3] = 'O';
                case3.Text = "O";
            }
            else if (tabMorpion[3] == tabMorpion[5] && tabMorpion[4] == ' ' && tabMorpion[3] == 'O')
            {
                tabMorpion[4] = 'O';
                case4.Text = "O";

            }
            else if (tabMorpion[6] == tabMorpion[7] && tabMorpion[8] == ' ' && tabMorpion[6] == 'O')
            {
                tabMorpion[8] = 'O';
                case8.Text = "O";
            }
            else if (tabMorpion[7] == tabMorpion[8] && tabMorpion[6] == ' ' && tabMorpion[7] == 'O')
            {
                tabMorpion[6] = 'O';
                case6.Text = "O";
            }
            else if (tabMorpion[6] == tabMorpion[8] && tabMorpion[7] == ' ' && tabMorpion[6] == 'O')
            {
                tabMorpion[7] = 'O';
                case7.Text = "O";

            }
            else if (tabMorpion[0] == tabMorpion[3] && tabMorpion[6] == ' ' && tabMorpion[0] == 'O')
            {
                tabMorpion[6] = 'O';
                case6.Text = "O";
            }
            else if (tabMorpion[3] == tabMorpion[6] && tabMorpion[0] == ' ' && tabMorpion[3] == 'O')
            {
                tabMorpion[0] = 'O';
                case0.Text = "O";
            }
            else if (tabMorpion[0] == tabMorpion[6] && tabMorpion[3] == ' ' && tabMorpion[0] == 'O')
            {
                tabMorpion[3] = 'O';
                case3.Text = "O";

            }
            else if (tabMorpion[1] == tabMorpion[4] && tabMorpion[7] == ' ' && tabMorpion[1] == 'O')
            {
                tabMorpion[7] = 'O';
                case7.Text = "O";
            }
            else if (tabMorpion[4] == tabMorpion[7] && tabMorpion[1] == ' ' && tabMorpion[4] == 'O')
            {
                tabMorpion[1] = 'O';
                case1.Text = "O";
            }
            else if (tabMorpion[1] == tabMorpion[7] && tabMorpion[4] == ' ' && tabMorpion[1] == 'O')
            {
                tabMorpion[4] = 'O';
                case4.Text = "O";

            }
            else if (tabMorpion[2] == tabMorpion[5] && tabMorpion[8] == ' ' && tabMorpion[2] == 'O')
            {
                tabMorpion[8] = 'O';
                case8.Text = "O";
            }
            else if (tabMorpion[5] == tabMorpion[8] && tabMorpion[2] == ' ' && tabMorpion[5] == 'O')
            {
                tabMorpion[2] = 'O';
                case2.Text = "O";
            }
            else if (tabMorpion[2] == tabMorpion[8] && tabMorpion[5] == ' ' && tabMorpion[2] == 'O')
            {
                tabMorpion[5] = 'O';
                case5.Text = "O";

            }
            else if (tabMorpion[0] == tabMorpion[4] && tabMorpion[8] == ' ' && tabMorpion[0] == 'O')
            {
                tabMorpion[8] = 'O';
                case8.Text = "O";
            }
            else if (tabMorpion[4] == tabMorpion[8] && tabMorpion[0] == ' ' && tabMorpion[4] == 'O')
            {
                tabMorpion[0] = 'O';
                case0.Text = "O";
            }
            else if (tabMorpion[0] == tabMorpion[8] && tabMorpion[4] == ' ' && tabMorpion[0] == 'O')
            {
                tabMorpion[4] = 'O';
                case4.Text = "O";

            }
            else if (tabMorpion[6] == tabMorpion[4] && tabMorpion[2] == ' ' && tabMorpion[6] == 'O')
            {
                tabMorpion[2] = 'O';
                case2.Text = "O";
            }
            else if (tabMorpion[4] == tabMorpion[2] && tabMorpion[6] == ' ' && tabMorpion[4] == 'O')
            {
                tabMorpion[6] = 'O';
                case6.Text = "O";
            }
            else if (tabMorpion[6] == tabMorpion[2] && tabMorpion[4] == ' ' && tabMorpion[6] == 'O')
            {
                tabMorpion[4] = 'O';
                case4.Text = "O";
            }
            else
            {
                iaPlayToDefend();
            }
        }

        void iaPlayToDefend()
        {
            if (tabMorpion[0] == tabMorpion[1] && tabMorpion[2] == ' ' && tabMorpion[0] == 'X')
            {
                tabMorpion[2] = 'O';
                case2.Text = "O";
            }
            else if (tabMorpion[1] == tabMorpion[2] && tabMorpion[0] == ' ' && tabMorpion[1] == 'X')
            {
                tabMorpion[0] = 'O';
                case0.Text = "O";
            }
            else if (tabMorpion[0] == tabMorpion[2] && tabMorpion[1] == ' ' && tabMorpion[0] == 'X')
            {
                tabMorpion[1] = 'O';
                case1.Text = "O";

            }
            else if (tabMorpion[3] == tabMorpion[4] && tabMorpion[5] == ' ' && tabMorpion[3] == 'X')
            {
                tabMorpion[5] = 'O';
                case5.Text = "O";
            }
            else if (tabMorpion[4] == tabMorpion[5] && tabMorpion[3] == ' ' && tabMorpion[4] == 'X')
            {
                tabMorpion[3] = 'O';
                case3.Text = "O";
            }
            else if (tabMorpion[3] == tabMorpion[5] && tabMorpion[4] == ' ' && tabMorpion[3] == 'X')
            {
                tabMorpion[4] = 'O';
                case4.Text = "O";

            }
            else if (tabMorpion[6] == tabMorpion[7] && tabMorpion[8] == ' ' && tabMorpion[6] == 'X')
            {
                tabMorpion[8] = 'O';
                case8.Text = "O";
            }
            else if (tabMorpion[7] == tabMorpion[8] && tabMorpion[6] == ' ' && tabMorpion[7] == 'X')
            {
                tabMorpion[6] = 'O';
                case8.Text = "O";
            }
            else if (tabMorpion[6] == tabMorpion[8] && tabMorpion[7] == ' ' && tabMorpion[6] == 'X')
            {
                tabMorpion[7] = 'O';
                case7.Text = "O";

            }
            else if (tabMorpion[0] == tabMorpion[3] && tabMorpion[6] == ' ' && tabMorpion[0] == 'X')
            {
                tabMorpion[6] = 'O';
                case6.Text = "O";
            }
            else if (tabMorpion[3] == tabMorpion[6] && tabMorpion[0] == ' ' && tabMorpion[3] == 'X')
            {
                tabMorpion[0] = 'O';
                case6.Text = "O";
            }
            else if (tabMorpion[0] == tabMorpion[6] && tabMorpion[3] == ' ' && tabMorpion[0] == 'X')
            {
                tabMorpion[3] = 'O';
                case3.Text = "O";

            }
            else if (tabMorpion[1] == tabMorpion[4] && tabMorpion[7] == ' ' && tabMorpion[1] == 'X')
            {
                tabMorpion[7] = 'O';
                case7.Text = "O";
            }
            else if (tabMorpion[4] == tabMorpion[7] && tabMorpion[1] == ' ' && tabMorpion[4] == 'X')
            {
                tabMorpion[1] = 'O';
                case1.Text = "O";
            }
            else if (tabMorpion[1] == tabMorpion[7] && tabMorpion[4] == ' ' && tabMorpion[1] == 'X')
            {
                tabMorpion[4] = 'O';
                case4.Text = "O";

            }
            else if (tabMorpion[2] == tabMorpion[5] && tabMorpion[8] == ' ' && tabMorpion[2] == 'X')
            {
                tabMorpion[8] = 'O';
                case8.Text = "O";
            }
            else if (tabMorpion[5] == tabMorpion[8] && tabMorpion[2] == ' ' && tabMorpion[5] == 'X')
            {
                tabMorpion[2] = 'O';
                case2.Text = "O";
            }
            else if (tabMorpion[2] == tabMorpion[8] && tabMorpion[5] == ' ' && tabMorpion[2] == 'X')
            {
                tabMorpion[5] = 'O';
                case5.Text = "O";

            }
            else if (tabMorpion[0] == tabMorpion[4] && tabMorpion[8] == ' ' && tabMorpion[0] == 'X')
            {
                tabMorpion[8] = 'O';
                case8.Text = "O";
            }
            else if (tabMorpion[4] == tabMorpion[8] && tabMorpion[0] == ' ' && tabMorpion[4] == 'X')
            {
                tabMorpion[0] = 'O';
                case0.Text = "O";
            }
            else if (tabMorpion[0] == tabMorpion[8] && tabMorpion[4] == ' ' && tabMorpion[0] == 'X')
            {
                tabMorpion[4] = 'O';
                case4.Text = "O";

            }
            else if (tabMorpion[6] == tabMorpion[4] && tabMorpion[2] == ' ' && tabMorpion[6] == 'X')
            {
                tabMorpion[2] = 'O';
                case2.Text = "O";
            }
            else if (tabMorpion[4] == tabMorpion[2] && tabMorpion[6] == ' ' && tabMorpion[4] == 'X')
            {
                tabMorpion[6] = 'O';
                case6.Text = "O";
            }
            else if (tabMorpion[6] == tabMorpion[2] && tabMorpion[4] == ' ' && tabMorpion[6] == 'X')
            {
                tabMorpion[4] = 'O';
                case4.Text = "O";
            }
            else if (tabMorpion[4] == ' ')
            {
                isCenterFree();
            }
            else
            {

                iaRandomPlay();
            }
        }

        void iaPlay()
        {
            iaPlayToWin();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void disableGame()
        {
            case0.Enabled = false;
            case1.Enabled = false;
            case2.Enabled = false;
            case3.Enabled = false;
            case4.Enabled = false;
            case5.Enabled = false;
            case6.Enabled = false;
            case7.Enabled = false;
            case8.Enabled = false;

        }

        private void activateGame()
        {
            case0.Enabled = true;
            case1.Enabled = true;
            case2.Enabled = true;
            case3.Enabled = true;
            case4.Enabled = true;
            case5.Enabled = true;
            case6.Enabled = true;
            case7.Enabled = true;
            case8.Enabled = true;
        }
    }
}
