using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyDay_SignUp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            txtAboutContent.Text =
        "About EasyDay\r\n\r\n" +
        "About the App\r\n" +
        "EasyDay: Making every workday easier.\r\n\r\n" +
        "EasyDay is a dedicated workplace communication assistant designed specifically for industries in Malaysia. Our mission is to bridge the language gap between supervisors and multilingual workers to improve daily operational efficiency, task accuracy, and workplace safety.\r\n\r\n" +
        "By translating daily schedules, work tasks, and safety guidelines into your native language with clear visual supports, we eliminate misunderstandings on the factory floor. With our built-in messaging system, we ensure that every worker can communicate confidently and instantly with their supervisors.\r\n\r\n" +
        "User Guidelines\r\n\r\n" +
        "For Supervisors: Managing Workloads and Communication\r\n\r\n" +
        "Step 1: Language Setup\r\n" +
        "Select your preferred operating language on the main screen.\r\n\r\n" +
        "Step 2: Assign To-Do Tasks\r\n" +
        "Navigate to the management portal to add, update, and distribute daily to-do tasks and schedules directly to your employees.\r\n\r\n" +
        "Step 3: Direct Messaging\r\n" +
        "Receive and reply to instant messages from your workers, allowing you to address floor issues or questions quickly without language barriers.\r\n\r\n" +
        "For Workers: Managing Your Day and Staying Connected\r\n\r\n" +
        "Step 1: Choose Your Language\r\n" +
        "Select your native language. The application supports Bahasa Melayu, English, Indonesian, Bengali, Burmese, and Nepali.\r\n\r\n" +
        "Step 2: Check Your Daily Tasks\r\n" +
        "Open your personal dashboard to view your assigned daily to-do list and schedules clearly translated.\r\n\r\n" +
        "Step 3: Message Your Supervisor\r\n" +
        "Use the chat feature to send direct messages to your supervisor if you have questions about your tasks or need help, ensuring your voice is heard.\r\n\r\n" +
        "Step 4: Follow Visual Safety Guides\r\n" +
        "Use the Safety Guide tab at any time to review picture-based instructions for Personal Protective Equipment (PPE), machine handling, and emergency safety procedures.";
        }
    }
    
}
