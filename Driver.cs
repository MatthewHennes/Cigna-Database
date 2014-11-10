using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinga_Database
{
  /// <summary>
  /// Used for test/demonstration purposes.
  /// </summary>
  public static class Driver
  {
    /// <summary>
    /// Runs tests.
    /// </summary>
    /// <param name="args">The arguments.</param>
    static void Main(string[] args)
    {
      policyHolderTests();
      Console.WriteLine("");
      doctorTests();
      Console.WriteLine("");
      hospitalTests();
    }

    /// <summary>
    /// Creates a PolicyHolder, links two Doctors and two Hospitals to it,
    /// and then prints out their names.
    /// </summary>
    private static void policyHolderTests()
    {
      PolicyHolder policyHolder1 = new PolicyHolder("PolicyHolder 1");
      Doctor doctor1 = new Doctor("Doctor 1");
      Doctor doctor2 = new Doctor("Doctor 2");
      Hospital hospital1 = new Hospital("Hospital 1");
      Hospital hospital2 = new Hospital("Hospital 2");

      LinkCreator.createLink(policyHolder1, doctor1);
      LinkCreator.createLink(doctor2, policyHolder1);
      LinkCreator.createLink(policyHolder1, hospital1);
      LinkCreator.createLink(hospital2, policyHolder1);

      Console.WriteLine("Doctors linked to " + policyHolder1 + ":");
      foreach (Doctor doctor in policyHolder1.getDoctors())
        Console.WriteLine(doctor);
      Console.WriteLine("\nHospitals linked to " + policyHolder1 + ":");
      foreach (Hospital hospital in policyHolder1.getHospitals())
        Console.WriteLine(hospital);

    }

    /// <summary>
    /// Creates a Doctor, links two Hospitals and two PolicyHolders to it,
    /// and then prints out their names.
    /// </summary>
    private static void doctorTests()
    {
      Doctor doctor1 = new Doctor("Doctor 1");
      Hospital hospital1 = new Hospital("Hospital 1");
      Hospital hospital2 = new Hospital("Hospital 2");
      PolicyHolder policyHolder1 = new PolicyHolder("PolicyHolder 1");
      PolicyHolder policyHolder2 = new PolicyHolder("PolicyHolder 2");

      LinkCreator.createLink(doctor1, hospital1);
      LinkCreator.createLink(hospital2, doctor1);
      LinkCreator.createLink(doctor1, policyHolder1);
      LinkCreator.createLink(policyHolder2, doctor1);

      Console.WriteLine("Hospitals linked to " + doctor1 + ":");
      foreach (Hospital hospital in doctor1.getHospitals())
        Console.WriteLine(hospital);
      Console.WriteLine("\nPolicyHolders linked to " + doctor1 + ":");
      foreach (PolicyHolder policyHolder in doctor1.getPolicyHolders())
        Console.WriteLine(policyHolder);
    }

    /// <summary>
    /// Creates a Hospital, links two PolicyHolders and two Hospitals to it,
    /// and then prints out their names.
    /// </summary>
    private static void hospitalTests()
    {
      Hospital hospital1 = new Hospital("Hospital 1");
      PolicyHolder policyHolder1 = new PolicyHolder("PolicyHolder 1");
      PolicyHolder policyHolder2 = new PolicyHolder("PolicyHolder 2");
      Doctor doctor1 = new Doctor("Doctor 1");
      Doctor doctor2 = new Doctor("Doctor 2");

      LinkCreator.createLink(hospital1, policyHolder1);
      LinkCreator.createLink(policyHolder2, hospital1);
      LinkCreator.createLink(hospital1, doctor1);
      LinkCreator.createLink(doctor2, hospital1);

      Console.WriteLine("PolicyHolders linked to " + hospital1 + ":");
      foreach (PolicyHolder policyHolder in hospital1.getPolicyHolders())
        Console.WriteLine(policyHolder);
      Console.WriteLine("\nDoctors linked to " + hospital1 + ":");
      foreach (Doctor doctor in hospital1.getDoctors())
        Console.WriteLine(doctor);
    }
  }
}