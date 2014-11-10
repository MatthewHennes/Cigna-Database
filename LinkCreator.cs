using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinga_Database
{
  /// <summary>
  /// Used to create links between two entities (PolicyHolders, Doctors, and Classes).
  /// </summary>
  public static class LinkCreator
  {
    #region Link Creators
    /// <summary>
    /// Creates a link between the given policyHolder and Doctor.
    /// This is done by: adding the given Doctor to the given policyHolder's list of Doctors
    ///                  adding the given PolicyHolder to the given Doctor's list of PolicyHolders
    /// </summary>
    /// <param name="policyHolder">The policy holder.</param>
    /// <param name="doctor">The doctor.</param>
    public static void createLink(PolicyHolder policyHolder, Doctor doctor)
    {
      policyHolder.addDoctor(doctor);
      doctor.addPolicyHolder(policyHolder);
    }

    /// <summary>
    /// Creates a link between the given PolicyHolder and Hospital.
    /// This is done by: adding the given PolicyHolder to the given Hospital's list of PolicyHolders
    ///                  adding the given Hospital to the given PolicyHolder's list of Hospitals
    /// </summary>
    /// <param name="policyHolder">The policy holder.</param>
    /// <param name="hospital">The hospital.</param>
    public static void createLink(PolicyHolder policyHolder, Hospital hospital)
    {
      policyHolder.addHospital(hospital);
      hospital.addPolicyHolder(policyHolder);
    }

    /// <summary>
    /// Creates a link between the given Doctor and PolicyHolder.
    /// This is done by: adding the given PolicyHolder to the given Doctor's list of PolicyHolders
    ///                  adding the given Doctor to the given policyHolder's list of Doctors
    /// </summary>
    /// <param name="doctor">The doctor.</param>
    /// <param name="policyHolder">The policy holder.</param>
    public static void createLink(Doctor doctor, PolicyHolder policyHolder)
    {
      doctor.addPolicyHolder(policyHolder);
      policyHolder.addDoctor(doctor);
    }

    /// <summary>
    /// Creates a link between the given Doctor and Hospital.
    /// This is done by: adding the given Hospital to the given Doctor's list of Doctors
    ///                  adding the given Doctor to the given Hospital's list of Doctors
    /// </summary>
    /// <param name="doctor">The doctor.</param>
    /// <param name="hospital">The hospital.</param>
    public static void createLink(Doctor doctor, Hospital hospital)
    {
      doctor.addHospital(hospital);
      hospital.addDoctor(doctor);
    }

    /// <summary>
    /// Creates a link between the given Hospital and PolicyHolder.
    /// This is done by: adding the given PolicyHolder to the given Hospital's list of PolicyHolders
    ///                  adding the given Hospital to the given policyHolder's list of Hospitals
    /// </summary>
    /// <param name="hospital">The hospital.</param>
    /// <param name="policyHolder">The policy holder.</param>
    public static void createLink(Hospital hospital, PolicyHolder policyHolder)
    {
      hospital.addPolicyHolder(policyHolder);
      policyHolder.addHospital(hospital);
    }

    /// <summary>
    /// Creates a link between the given Hospital and Doctor.
    /// This is done by: adding the given Hospital to the given Doctor's list of Hospitals
    ///                  adding the given Doctor to the given Hospital's list of Doctors
    /// </summary>
    /// <param name="hospital">The hospital.</param>
    /// <param name="doctor">The doctor.</param>
    public static void createLink(Hospital hospital, Doctor doctor)
    {
      hospital.addDoctor(doctor);
      doctor.addHospital(hospital);
    }
    #endregion
  }
}