using System;

namespace StudentMangement
{
    public class Student
    {
        public int StudentId {get; private set;}
        public string Fullname { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        private double math;
        private double physics;
        private double chemistry;
        private double aveScore => CalsAveScore();
        private string rank => Rank();

        public Student(int studentId, string fn, int age, bool gender)
        {
            StudentId = studentId;
            Fullname = fn;
            Age = age;
            Gender = gender;
        }
        
        public void InputScores(double math, double physics, double chemistry)
        {
            this.math = math;
            this.physics = physics;
            this.chemistry = chemistry;
        }

        public string Print(){
            return $"{StudentId}\t{Fullname}\t\t{Age}\t{(Gender? "Male" : "Female")}\t{math}\t{physics}\t{chemistry}\t\t{aveScore}\t\t{rank}\n";
        }

        private double CalsAveScore(){
            return Math.Round((math * 2 + physics + chemistry)/4,1);
        }

        private string Rank(){
            if(aveScore >= 9 && aveScore <=10){
                return "Excellent";
            }
            else if(aveScore >= 8){
                return "Great";
            }
            else if(aveScore >= 7){
                return "Good";
            }
            else if(aveScore >= 5){
                return "Mendium";
            }
            else{
                return "Bad";
            }
        }
    }
}