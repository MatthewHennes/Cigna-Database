using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinga_Database
{
  /// <summary>
  /// Represents a Hospital.
  /// Contains:
  ///   List of PolicyHolders
  ///   List of Doctors
  ///   string name
  /// </summary>
  public class Hospital
  {
    #region instance variables
    private List<PolicyHolder> policyHolders;
    private List<Doctor> doctors;
    private string name;
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="Hospital"/> class with the given name.
    /// </summary>
    /// <param name="name">The name.</param>
    public Hospital(string name)
    {
      policyHolders = new List<PolicyHolder>();
      doctors = new List<Doctor>();
      this.name = name;
    }

    #region Get Functions
    /// <summary>
    /// Gets the policy holders.
    /// Safe get (returns copy rather than reference).
    /// </summary>
    /// <returns></returns>
    public List<PolicyHolder> getPolicyHolders()
    {
      return new List<PolicyHolder>(policyHolders);
    }

    /// <summary>
    /// Gets the doctors.
    /// Safe get (returns copy rather than reference).
    /// </summary>
    /// <returns></returns>
    public List<Doctor> getDoctors()
    {
      return new List<Doctor>(doctors);
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
    /// Adds the policy holder.
    /// </summary>
    /// <param name="policyHolder">The policy holder.</param>
    public void addPolicyHolder(PolicyHolder policyHolder)
    {
      policyHolders.Add(policyHolder);
    }

    /// <summary>
    /// Adds the doctor.
    /// </summary>
    /// <param name="doctor">The doctor.</param>
    public void addDoctor(Doctor doctor)
    {
      doctors.Add(doctor);
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