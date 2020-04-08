using System;
using Unity;

namespace DIByUnity
{
    public interface IUniversity
    {
        void ShowResult();
    }

    class University:IUniversity
    {
        public void ShowResult()
        {
            Console.WriteLine("You got first division in Engineering program.");
        }
    }

    public interface IStudent
    {
    }
    public class Student : IStudent
    {
        private IUniversity _University;
        [Dependency]
        public IUniversity University
        {
            get { return _University; }
            set { _University = value; }
        }

        //// Dependency Injection by constructor
        //[InjectionConstructor]
        //public Student(IUniversity tmpUniversity)   
        //{
        //    _University = tmpUniversity;  
        //}  

        //// Dependency Injection by method
        //[InjectionMethod]
        //public void SetObject(IUniversity tmpUniversity)
        //{
        //    _University = tmpUniversity;
        //}  

        public void DisplayResult()
        {
            _University.ShowResult();
        }
    }
}
