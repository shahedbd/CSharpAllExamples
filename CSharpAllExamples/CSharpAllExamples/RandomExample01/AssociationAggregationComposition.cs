using System.Collections.Generic;


//Aggregation: Has-a. It has an existing object of another type
//Composition: Is composed of another object
//Association: I have two views on this.
//When one class is associated with another.Hence both the above are examples of association.
//Association is a weaker form of Aggregation where the class doesn't keep a reference to the object it receives.


namespace CSharpAllExamples.RandomExample01
{
    class AssociationAggregationComposition
    {
        Manger oManger = new Manger();
        SwipeCard oSwipeCard = new SwipeCard();

    }

    public class Manger
    {
        public Project oProject;
        public Manger()
        {
            oProject = new Project();
        }

        //Aggregation relation: Only belong to the manager(Worker)
        List<Worker> workers = new List<Worker>();
        public void Logon(SwipeCard obj)
        {
            obj.Swipe(this);
        }

        public string GetManagerName()
        {
            return "Jovan";
        }


        public double Salary;

        public void HowIsTheManger(bool Good)
        {
            if (Good)
            {
                oProject.IsSuccess = true;
            }
            else
            {
                oProject.IsSuccess = false;
            }
        }

    }


    public class SwipeCard
    {
        public void Swipe(Manger obj)
        {
            obj.Logon(this);
        }

        public string MakeOfSwipeCard()
        {
            return "c001";
        }
    }


    public class Worker
    {
        public string WorkerName { get; set; }
    }


    public class Project
    {
        private Manger oManger;
        public bool IsSuccess = false;

        public bool Issuccess
        {
            get { return IsSuccess; }
            set
            {
                IsSuccess = value;
                if (value)
                {
                    oManger.Salary++;
                }
                else
                {
                    oManger.Salary--;
                }
            }
        }
    }

}
