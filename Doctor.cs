using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinga_Database
{
  /// <summary>
  /// Represents a Doctor.
  /// Contains:
  ///   List of PolicyHolders
  ///   List of Hospitals
  ///   string name
  /// </summary>
  public class Doctor
  {
    #region instance variables
    private List<PolicyHolder> policyHolders;
    private List<Hospital> hospitals;
    private string name;
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="Doctor"/> class with the given name.
    /// </summary>
    /// <param name="name">The name.</param>
    public Doctor(string name)
    {
      policyHolders = new List<PolicyHolder>();
      hospitals = new List<Hospital>();
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
    /// Gets the hospitals.
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
    /// Adds the policy holder.
    /// </summary>
    /// <param name="policyHolder">The policy holder.</param>
    public void addPolicyHolder(PolicyHolder policyHolder)
    {
      policyHolders.Add(policyHolder);
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