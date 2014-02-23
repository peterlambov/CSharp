using System;
using System.Linq;
using System.Text;

public class Student:ICloneable,IComparable<Student>
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string sSN;             //SSN
    private string permanentAddress;
    private decimal mobilePhone;
    private string email;
    private int course;
    private Specialty specialty;
    private Univesity university;
    private Faculty faculty;
    //constructor
    public Student(string firstName, string middleName, string lastNAme,
                   string ssn, string permanentAddress, decimal mobilePhone, string email, int course,
                   Specialty specialty, Univesity university, Faculty faculty)
    {

        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastNAme;
        this.SSN = ssn;
        this.PermanentAddress = permanentAddress;
        this.MobilePhone = mobilePhone;
        this.Email = email;
        this.Course = course;
        this.Specialty = specialty;
        this.University = university;
        this.Faculty = faculty;
    }

    public Student()
    {

    }


 
    //properties
    public Faculty Faculty
    {
        get
        {
            return this.faculty;
        }
        set
        {
            this.faculty = value;
        }
    }

    public Univesity University
    {
        get
        {
            return this.university;
        }
        set
        {
            this.university = value;
        }
    }

    public Specialty Specialty
    {
        get
        {
            return this.specialty;
        }
        set
        {
            this.specialty = value;
        }
    }

    public int Course
    {
        get
        {
            return this.course;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }
            this.course = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException();
            }
            this.email = value;
        }
    }

    public decimal MobilePhone
    {
        get
        {
            return this.mobilePhone;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }
            this.mobilePhone = value;
        }
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException();
            }
            this.firstName = value;
        }
    }

    public string MiddleName
    {
        get { return this.middleName; }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException();
            }
            this.middleName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException();
            }
            this.lastName = value;
        }
    }

    public string   SSN
    {
        get { return this.sSN; }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException();
            }
            this.sSN = value;
        }
    }

    public string PermanentAddress
    {
        get { return this.permanentAddress; }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException();
            }
            this.permanentAddress = value;
        }
    }

    //methods
    public override bool Equals(object obj)
    {
        Student student = obj as Student;
        if (student == null)
        {
            return false;
        }
 
        if (!Object.Equals(this.sSN, student.sSN)) //We assume that SSN is unique so this sign is enough to say wether two students are equal or not.
        {
            return false;
        }
        return true;
    }

    public static bool operator ==(Student firstStudent, Student secondStudent)
    {
        return Student.Equals(firstStudent, secondStudent);
    }

    public static bool operator !=(Student firstStudent, Student secondStudent)
    {
        return !Student.Equals(firstStudent, secondStudent);
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ MiddleName.GetHashCode();
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine(this.firstName);
        result.AppendLine(this.middleName);
        result.AppendLine(this.lastName);
        result.AppendLine(this.sSN.ToString());
        result.AppendLine(this.permanentAddress);
        result.AppendLine(this.MobilePhone.ToString());
        result.AppendLine(this.Email);
        result.AppendLine(this.Course.ToString());
        result.AppendLine(this.Specialty.ToString());
        result.AppendLine(this.University.ToString());
        result.AppendLine(this.Faculty.ToString());
        return result.ToString();
    }


    public object Clone() //public Student Clone() would give the same result and we would not have to cast when we clone some student.
    {
        Student copiedStudent = new Student(this.firstName,this.middleName,this.lastName,this.sSN,this.permanentAddress,this.mobilePhone,
            this.email,this.course,this.specialty,this.university,this.faculty);
        return copiedStudent as object;
       
    }

    public int CompareTo(Student other)
    {
        if (this.firstName!=other.firstName)
        {
            return this.FirstName.CompareTo(other.firstName);
        }
        else if (this.middleName!=other.middleName)
        {
            return this.middleName.CompareTo(other.middleName);   
        }
        else if (this.lastName!=other.lastName)
        {
            return this.lastName.CompareTo(other.lastName);
        }
        else  if (this.sSN!=other.sSN)
        {
            return this.sSN.CompareTo(other.sSN);
        }
        else
        {
            return 0;
        } 
    }
}

