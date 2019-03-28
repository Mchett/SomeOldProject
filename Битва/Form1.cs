using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Битва
{
    public partial class A : Form
    {



        public A()
        {
            InitializeComponent();
        }

        ObserverDeath OD;
        ObserverClone OC;
        FileObserver OF = new FileObserver();

        void textBox1_LostFocus(object sender, EventArgs e)
   {
       try {
           if (textBox1.Text != "")
           {
               int y = Math.Abs(Convert.ToInt16(textBox1.Text));
               textBox1.Text = Convert.ToString(y);
           }
       }
       catch
       {
           MessageBox.Show("Стоимость должна быть целым числом.", "Error.", MessageBoxButtons.OK);
           textBox1.Text ="";

       }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите стоимость армий.", "Error.", MessageBoxButtons.OK);
                    return;
                }

                BattleField Battle = BattleField.getBat();
                groupBox2.Enabled = true;
            
                Battle.CreateArmy(Convert.ToInt16(textBox1.Text));
                Battle.AddObserverF(OF);

                Battle.CreateCom(UnDo, ReDo);
                Battle.ShowArmy(ArmyA, ArmyB);
                Start.Enabled = true;
                OneStep.Enabled = true;
           
        }
        private void MyThread()
        {
            BattleField Battle = BattleField.getBat();
            Battle.DelR();
            int i = Battle.DoMany(ArmyA, ArmyB);
            if (i==1 ||i ==2)
            {
                if (i == 1)
                {
                    string s = Battle.WhoWin() + " выиграли!";
                    Battle.NotifyObserverF(s);

                    MessageBox.Show(s, "Win!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ничья.", "GameOver!", MessageBoxButtons.OK);
                    Battle.NotifyObserverF("Ничья.");
                }
                Restart.Invoke(new Action(() => Restart.Enabled = true));
                UnDo.Invoke(new Action(() => UnDo.Enabled = false));
                ReDo.Invoke(new Action(() => ReDo.Enabled = false));
                OneStep.Invoke(new Action(() => OneStep.Enabled = false));
                Start.Invoke(new Action(() => Start.Enabled = false));
                Pause.Invoke(new Action(() => Pause.Enabled = false));
                groupBox2.Invoke(new Action(() => groupBox2.Enabled = true));

                groupBox1.Invoke(new Action(() => groupBox1.Enabled = true));
    
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Invoke(new Action(() => groupBox2.Enabled = false));

            groupBox1.Invoke(new Action(() => groupBox1.Enabled = false));
           button1.Invoke(new Action(()=>button1.Enabled = false));
           button1.Invoke(new Action(()=> button1.Enabled = false));
             Restart.Invoke(new Action(()=> Restart.Enabled = false));
          UnDo.Invoke(new Action(()=>  UnDo.Enabled = false));
          ReDo.Invoke(new Action(() => ReDo.Enabled = false));
          OneStep.Invoke(new Action(()=>OneStep.Enabled = false));
          Start.Invoke(new Action(()=>Start.Enabled = false));
          Pause.Invoke(new Action(()=>Pause.Enabled = true));
           System.Threading.Thread MY = new System.Threading.Thread( MyThread);
           MY.Start();
        }

        private void OneStep_Click(object sender, EventArgs e)
        {
            UnDo.Enabled = true;
            button1.Enabled = false;
            Restart.Enabled = true;
            Pause.Enabled = false;
            Restart.Enabled = true;
            BattleField Battle = BattleField.getBat();
            Battle.DelR();
            ReDo.Enabled = false;
            int i = Battle.DoOne(ArmyA, ArmyB);
            if (i==1 || i==2)
            {

                if (i == 1)
                {

                    string s = Battle.WhoWin() + " выиграли!";
                    Battle.NotifyObserverF(s);

                    MessageBox.Show(s, "Win!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ничья.", "GameOver!", MessageBoxButtons.OK);
                    Battle.NotifyObserverF("Ничья.");
                }

                Restart.Enabled = true;
                UnDo.Enabled = false;
                ReDo.Enabled = false;
                OneStep.Enabled = false;
                Start.Enabled = false;
                Pause.Enabled = false;
            }

        }

        private void Pause_Click(object sender, EventArgs e)
        {
            groupBox1.Invoke(new Action(() => groupBox1.Enabled = false));

            BattleField Battle = BattleField.getBat();
            Pause.Enabled = false;
            UnDo.Enabled = true;
            OneStep.Enabled = true;
            Start.Enabled = true;
            Restart.Enabled = true;
            groupBox2.Enabled = true;
            groupBox1.Enabled = true;
            Battle.Pause();


        }

        private void Restart_Click(object sender, EventArgs e)
        {
            BattleField Battle = BattleField.getBat();
            Death.Checked = false;
            clone.Checked = false;
            clone_CheckedChanged( sender,  e);
            Death_CheckedChanged(sender, e);
            groupBox2.Enabled = false;
            Battle.DelR();
            Battle.DelU();
            Battle.DelB();
            Battle.NotifyObserverF("Начата новая игра");
            button1.Enabled = true;
            Restart.Enabled = false;
            UnDo.Enabled = false;
            ReDo.Enabled = false;
            OneStep.Enabled = false;
            Start.Enabled = false;
            Pause.Enabled = false;
            ArmyA.Rows.Clear();
            ArmyB.Rows.Clear();

        }

        private void one_CheckedChanged(object sender, EventArgs e)
        {
            BattleField Battle = BattleField.getBat();
            Battle.ChangeStrategy(1);

        }

        private void two_CheckedChanged(object sender, EventArgs e)
        {
            BattleField Battle = BattleField.getBat();
            Battle.ChangeStrategy(2);

        }

        private void many_CheckedChanged(object sender, EventArgs e)
        {
            BattleField Battle = BattleField.getBat();
            Battle.ChangeStrategy(3);
        }

        private void UnDo_Click(object sender, EventArgs e)
        {
            BattleField Battle = BattleField.getBat();
            Battle.Undo();
            Battle.ShowArmy(ArmyA, ArmyB);




        }

        private void ReDo_Click(object sender, EventArgs e)
        {
            BattleField Battle = BattleField.getBat();
            Battle.Redo();
            Battle.ShowArmy(ArmyA, ArmyB);


        }

        private void Death_CheckedChanged(object sender, EventArgs e)
        {
           
            BattleField Battle = BattleField.getBat();

            if (Death.Checked)
            {
                OD = new ObserverDeath(ArmyA, ArmyB);
                Battle.AddObserverD(OD);
            }
            else
                Battle.RemoveObserverD(OD);

        }

        private void clone_CheckedChanged(object sender, EventArgs e)
        {
           
            BattleField Battle = BattleField.getBat();

            if (clone.Checked)
            {
                OC = new ObserverClone();
                Battle.AddObserverC(OC);
            }
            else
                Battle.RemoveObserverC(OC);


        }

        private void Help_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }


    }
}
