using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpAllExamples.RandomExample01.LazyLoadingPattern
{
    class LazyLoadingPattern
    {
    }


    public class EducationProfile
    {
        public int Id { get; set; }
        public string Degree { get; set; }
        public DateTime PassingYear { get; set; }
    }


    //Hope this will give you a little reference of lazy loading     

    public class Candiate
    {
        Lazy<List<EducationProfile>> educationProileList;

        public string Name { get; set; }
        public int EducationProfileId { get; set; }
        public List<EducationProfile> GetAllEducationProfile()
        {
            return educationProileList.Value;
        }



        public Candiate(string name, int id)
        {
            //Initializing Candiate Object    
            Name = name;
            EducationProfileId = id;
            educationProileList = new Lazy<List<EducationProfile>>(() => { return GetEducationProfileList(id); });
            //Initialization done    
        }

        private List<EducationProfile> GetEducationProfileList(int id)
        {
            //Loading EducationProiles    
            List<EducationProfile> list = new List<EducationProfile>();
            Parallel.For(100, 110, (int i) =>
            {
                EducationProfile educationprofile = new EducationProfile();
                educationprofile.Id = i;
                list.Add(educationprofile);
            });
            return list;
        }
    }



    public class LazyLoadingPatternTest2
    {
        private List<string> list = null;
        public LazyLoadingPatternTest2()
        {
            Console.WriteLine("List Generated:");
            list = new List<string>()
            {
                "Sourav","Ram", "Jam"
            };
        }


        public List<string> Names
        {
            get { return list; }
            set { list = value; }
        }


        public void IMPLazyLoadingPattern()
        {
            Lazy<LazyLoadingPatternTest2> lazy = new Lazy<LazyLoadingPatternTest2>();
            Console.WriteLine("Data Loaded : " + lazy.IsValueCreated);


            LazyLoadingPatternTest2 _LazyLoadingPatternTest2 = lazy.Value;

            foreach (var item in _LazyLoadingPatternTest2.Names)
            {
                Console.WriteLine(item);
            }
        }



    }
}
