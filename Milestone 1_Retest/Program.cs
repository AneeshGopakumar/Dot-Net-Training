using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Milestone_1_Retest_assessment
{
    class Doctors
    {

        //+++++Variables*****//
        private static readonly Regex AlphabeticRegex = new Regex("^[a-zA-Z ]*$", RegexOptions.Compiled);
        private static readonly Regex NumCharSpecialRegex = new Regex("^(?=.*[a-zA-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+=-]).*$", RegexOptions.Compiled);

        private int IntRegNoVal;
        public int IntRegNo 
        { 
            get => IntRegNoVal; 
            set 
            { 
                if (value < 1000000 || value > 9999999) throw new System.Exception("Reg. no should have 7 digits only.");
                IntRegNoVal = value;
            }            
        }

        private string StrDoctorNameVal;
        public string StrDoctorName
        {
            get => StrDoctorNameVal;
            set
            {
                if (!AlphabeticRegex.IsMatch(value) || String.IsNullOrEmpty(value.Trim()))
                {
                    throw new System.Exception("Doctor Name must contain only alphabetic characters.");
                }
                StrDoctorNameVal = value;
            }
        }

        private string StrSpecAreaVal;
        public string StrSpecArea
        {
            get=> StrSpecAreaVal; 
            set
            {
                if (!AlphabeticRegex.IsMatch(value) || String.IsNullOrEmpty(value.Trim()))
                {
                    throw new System.Exception("Area of specialization must contain only alphabetic characters.");
                }
                StrSpecAreaVal = value;
            }
        }
        public string StrCity { get; set; }
        public string StrClinicAddress { get; set; }
        private string StrClinicTimingsVal;
        public string StrClinicTimings
        {
            get=>StrClinicTimingsVal;
            set
            {
                if (!NumCharSpecialRegex.IsMatch(value))
                {
                    throw new System.Exception("Clinic Timings must contain alphabetic/numeric/special characters.");
                }
                StrClinicTimingsVal = value;
            }
        }
        private double DblContactNoVal;
        public double DblContactNo 
        { 
            get=>DblContactNoVal; 
            set 
            { 
                if (value < 1000000000 || value > 9999999999) throw new System.Exception("ContactNo no. should have 10 digits only.");
                DblContactNoVal = value;
            } 
        }

        //+++++Function to get details about the doctor as user input*****// 
        public Doctors GetDoctorDetails()
        {
            Console.WriteLine("*Enter 7 digit registration number: ");
            IntRegNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*Enter Doctor Name (use alphabets only): ");
            StrDoctorName = Console.ReadLine();
            Console.WriteLine("*Enter Area of Specialization (use alphabets only): ");
            StrSpecArea = Console.ReadLine();
            Console.WriteLine("*Enter City: ");
            StrCity = Console.ReadLine();
            Console.WriteLine("*Enter Clinic Address: ");
            StrClinicAddress = Console.ReadLine();
            Console.WriteLine("*Enter Clinic Timings (use alphanumeric value with special character): ");
            StrClinicTimings = Console.ReadLine();
            Console.WriteLine("*Enter 10 digit contact No.: ");
            DblContactNo = Convert.ToDouble(Console.ReadLine());
            return this;
        }
    }
    internal class DoctorDetails
    {
        static void Main(string[] args)
        {
            int OptionSelected = 0;
            List<Doctors> DoctorsList = new List<Doctors>();
            while (OptionSelected != 4)
            {
                Console.WriteLine("\n--Menu--\n1.Add Doctor\n2.Display Doctor\n3.Search Doctor\n4.Exit");
                OptionSelected = int.Parse(Console.ReadLine());
                switch (OptionSelected)
                {
                    case 1:
                        //+++++Add Doctor
                        Doctors Doctor = new Doctors();
                        DoctorsList.Add(Doctor.GetDoctorDetails());
                        break;
                    case 2:
                        //+++++Display Doctors*****//
                        if (DoctorsList.Count == 0)
                            Console.WriteLine("No doctors in collection");
                        else
                            foreach (Doctors Doc in DoctorsList)
                            {
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Reg. No.: " + Doc.IntRegNo + "\nDoctor Name: " + Doc.StrDoctorName + "\nArea of Specialization.: "
                                    + Doc.StrSpecArea + "\nCity: " + Doc.StrCity + "\nClinic Address: " + Doc.StrClinicAddress
                                    + "\nClinic Timings: " + Doc.StrClinicTimings + "\nContact No: " + Doc.DblContactNo);
                            }
                        break;

                    case 3:
                        
                        //+++++Search Doctor*****//
                        Console.WriteLine("\nEnter ailment details: ");
                        string StrAilment = Console.ReadLine();
                        List<Doctors> RelevantDoctorsList = new List<Doctors>();
                        RelevantDoctorsList = DoctorsList.Where(p => p.StrSpecArea.Contains(StrAilment, StringComparison.CurrentCultureIgnoreCase)).ToList();
                        //+++++Display Doctor*****//
                        if (RelevantDoctorsList.Count == 0)
                            Console.WriteLine("No doctors matching the criteria");
                        else

                            foreach (Doctors Doc in RelevantDoctorsList)
                            {
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Reg. No.: " + Convert.ToString(Doc.IntRegNo) + "\nDoctor Name: " + Doc.StrDoctorName + "\nArea of Specialization.: "
                                    + Doc.StrSpecArea + "\nCity: " + Doc.StrCity + "\nClinic Address: " + Doc.StrClinicAddress
                                    + "\nClinic Timings: " + Doc.StrClinicTimings + "\nContact No: " + Convert.ToString(Doc.DblContactNo));
                            }
                        break;

                    case 4:
                        //+++++Exit menu*****//
                        break;
                    default:
                        //+++++Invalid selection*****//
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            }
        }
    }
}