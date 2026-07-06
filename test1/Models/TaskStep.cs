using System;

namespace EasyDay_SignUp.Models
{
    public class TaskStep
    {
        public int StepNumber { get; set; }
        public string Instruction { get; set; } = string.Empty;

        public TaskStep(int stepNumber, string instruction)
        {
            StepNumber = stepNumber;
            Instruction = instruction;
        }
    }
}