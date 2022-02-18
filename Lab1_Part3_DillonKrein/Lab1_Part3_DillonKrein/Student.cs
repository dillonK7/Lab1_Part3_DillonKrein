using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Dillon Krein
//2-11-2022
//Student class for each object with getters and setters
namespace Lab1_Part3_DillonKrein
{
    public class Student
    {
    private String firstName;
    private String lastName;
    private String email;
    private String phoneNumber;
    private String expectedGradYear;
    private String major;
    private String universityYear;
    private String internshipStatus;
    private String employmentStatus;
    public int studentID { get; set; }

    private static int nextStudent = 150;

    public Student(string firstName, string lastName, string email, string phoneNumber, string expectedGradYear, string major, string universityYear, string internshipStatus, string employmentStatus)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.expectedGradYear = expectedGradYear;
        this.major = major;
        this.universityYear = universityYear;
        this.internshipStatus = internshipStatus;
        this.employmentStatus = employmentStatus;
        this.studentID = nextStudent++;
    }
    public string FirstName
    {
        get { return this.firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return this.lastName; }
        set { lastName = value; }
    }
    public string Email
    {
        get { return this.email; }
        set { email = value; }
    }
    public string PhoneNumber
    {
        get { return this.phoneNumber; }
        set { phoneNumber = value; }
    }
    public string ExpectedGradYear
    {
        get { return this.expectedGradYear; }
        set { expectedGradYear = value; }
    }
    public string Major
    {
        get { return this.major; }
        set { major = value; }
    }
    public string UniversityYear
    {
        get { return this.universityYear; }
        set { universityYear = value; }
    }
    public string InternshipStatus
    {
        get { return this.internshipStatus; }
        set { internshipStatus = value; }
    }
    public string EmploymentStatus
    {
        get { return this.employmentStatus; }
        set { employmentStatus = value; }
    }
}
}