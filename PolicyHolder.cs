using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinga_Database
{
  /// <summary>
  /// Represents a PolicyHolder.
  /// Contains:
  ///   List of Doctors
  ///   List of Hospitals
  ///   string name
  /// </summary>
  public class PolicyHolder
  {
    #region instance variables
    private List<Doctor> doctors;
    private List<Hospital> hospitals;
    private string name;
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyHolder"/> class with the given name.
    /// </summary>
    /// <param name="name">The name.</param>
    public PolicyHolder(string name)
    {
      doctors = new List<Doctor>();
      hospitals = new List<Hospital>();
      this.name = name;
    }

    #region Get Functions
    /// <summary>
    /// Gets the list of Doctors.
    /// Safe get (returns copy rather than reference).
    /// </summary>
    /// <returns></returns>
    public List<Doctor> getDoctors()
    {
      return new List<Doctor>(doctors);
    }

    /// <summary>
    /// Gets the list of Hospitals.
    /// Safe get (returns copy rather than reference).
    /// </summary>
    /// <returns></returns>
    public List<Hospital> getHospitals()
    {
      return new List<Hospital>(hospitals);
    }

    /// <summary>
    /// Gets the name.
    /// Safe get (returns copy rather than reference).
    /// </summary>
    /// <returns></returns>
    public string getName()
    {
      return name.ToString();
    }
    #endregion

    #region Add Functions
    /// <summary>
    /// Adds the doctor.
    /// </summary>
    /// <param name="doctor">The doctor.</param>
    public void addDoctor(Doctor doctor)
    {
      doctors.Add(doctor);
    }

    /// <summary>
    /// Adds the hospital.
    /// </summary>
    /// <param name="hospital">The hospital.</param>
    public void addHospital(Hospital hospital)
    {
      hospitals.Add(hospital);
    }
    #endregion

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      return name;
    }
  }
}