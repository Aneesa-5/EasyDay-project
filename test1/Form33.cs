using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test1;

namespace EasyDay_SignUp
{
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnPPE_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
 "⚠️ WARNING! ⚠️\n\n" +
 "Going to work without PPE?\n" +
 "Your boss: 😡\n" +
 "Your safety officer: 🚨\n\n" +
 "Before entering, wear:\n" +
 "✔ Safety Helmet\n" +
 "✔ Safety Glasses\n" +
 "✔ Safety Gloves\n" +
 "✔ Safety Boots\n" +
 "✔ Safety Vest\n\n" +
 "Remember: Better look funny in PPE than look cool in the hospital! 😂",
 "PPE Alert",
 MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            "☣️ CHEMICAL SAFETY ALERT ☣️\n\n" +
        "❌ Don't sniff it.\n" +
        "❌ Don't taste it.\n" +
        "❌ Don't mix it.\n\n" +
        "✔ Wear PPE.\n" +
        "✔ Read the label.\n" +
        "✔ Store chemicals safely.\n" +
        "✔ Clean spills immediately.\n\n" +
        "💡 Remember: Curiosity is good, but not with chemicals! 😄",
        "Handling Chemicals",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            "⚙️ MACHINE SAFETY ⚙️\n\n" +
        "✔ Read the machine manual before use.\n\n" +
        "✔ Wear appropriate PPE.\n\n" +
        "✔ Keep hands away from moving parts.\n\n" +
        "✔ Do not operate damaged machines.\n\n" +
        "✔ Turn off the machine before cleaning or maintenance.\n\n" +
        "✔ Report any faults to the supervisor immediately.\n\n" +
        "Stay alert. Safety first!",
        "Machine Safety",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "🔥 FIRE SAFETY 🔥\n\n" +
       "🧯 Know the location of fire extinguishers.\n\n" +
       "🚪 Keep emergency exits clear at all times.\n\n" +
       "🚭 Do not smoke in restricted areas.\n\n" +
       "⚡ Switch off electrical equipment when not in use.\n\n" +
       "🚨 If a fire occurs, activate the fire alarm immediately.\n\n" +
       "🏃 Evacuate calmly and assemble at the designated assembly point.\n\n" +
       "⚠️ Remember: Stay calm, don't panic!",
       "Fire Safety",
       MessageBoxButtons.OK,
       MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "🚑 EMERGENCY PROCEDURES 🚑\n\n" +
            "📞 Stay calm and call for help immediately.\n\n" +
            "🚨 Activate the emergency alarm if necessary.\n\n" +
            "🚪 Evacuate using the nearest emergency exit.\n\n" +
            "🏃 Do not use elevators during an emergency.\n\n" +
            "📍 Gather at the designated assembly point.\n\n" +
            "👨‍🚒 Follow the instructions of emergency personnel.\n\n" +
            "⚠️ Remember: Stay calm, stay safe!",
            "Emergency Procedures",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           "💧 WATER SAFETY 💧\n\n" +
           "🏊 Never swim alone.\n\n" +
           "🦺 Wear a life jacket when boating or near deep water.\n\n" +
           "🚫 Avoid running near swimming pools or wet surfaces.\n\n" +
           "👀 Always supervise children near water.\n\n" +
           "🌊 Do not enter water during storms or strong currents.\n\n" +
           "📞 Call for help immediately in case of a water emergency.\n\n" +
           "⚠️ Remember: Water is fun, but safety comes first!",
           "Water Safety",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }

        private void btnMessageSupervisor_Click(object sender, EventArgs e)
        {
            Form22 frm = new Form22();
            frm.ShowDialog();
        }
    }
}
