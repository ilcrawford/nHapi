using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V28.Segment;
using NHapi.Model.V28.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V28.Group
{
///<summary>
///Represents the CCI_I22_MEDICATION_ADMINISTRATION_DETAIL Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: RXA (Pharmacy/Treatment Administration) repeating</li>
///<li>1: RXR (Pharmacy/Treatment Route) </li>
///<li>2: CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION (a Group object) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class CCI_I22_MEDICATION_ADMINISTRATION_DETAIL : AbstractGroup {

	///<summary> 
	/// Creates a new CCI_I22_MEDICATION_ADMINISTRATION_DETAIL Group.
	///</summary>
	public CCI_I22_MEDICATION_ADMINISTRATION_DETAIL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RXA), true, true);
	      this.add(typeof(RXR), true, false);
	      this.add(typeof(CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating CCI_I22_MEDICATION_ADMINISTRATION_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns  first repetition of RXA (Pharmacy/Treatment Administration) - creates it if necessary
	///</summary>
	public RXA GetRXA() {
	   RXA ret = null;
	   try {
	      ret = (RXA)this.GetStructure("RXA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RXA
	/// * (Pharmacy/Treatment Administration) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RXA GetRXA(int rep) { 
	   return (RXA)this.GetStructure("RXA", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXA 
	 */ 
	public int RXARepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RXA").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RXA results 
	 */ 
	public IEnumerable<RXA> RXAs 
	{ 
		get
		{
			for (int rep = 0; rep < RXARepetitionsUsed; rep++)
			{
				yield return (RXA)this.GetStructure("RXA", rep);
			}
		}
	}

	///<summary>
	///Adds a new RXA
	///</summary>
	public RXA AddRXA()
	{
		return this.AddStructure("RXA") as RXA;
	}

	///<summary>
	///Removes the given RXA
	///</summary>
	public void RemoveRXA(RXA toRemove)
	{
		this.RemoveStructure("RXA", toRemove);
	}

	///<summary>
	///Removes the RXA at the given index
	///</summary>
	public void RemoveRXAAt(int index)
	{
		this.RemoveRepetition("RXA", index);
	}

	///<summary>
	/// Returns RXR (Pharmacy/Treatment Route) - creates it if necessary
	///</summary>
	public RXR RXR { 
get{
	   RXR ret = null;
	   try {
	      ret = (RXR)this.GetStructure("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION GetMEDICATION_ADMINISTRATION_OBSERVATION() {
	   CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION ret = null;
	   try {
	      ret = (CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION)this.GetStructure("MEDICATION_ADMINISTRATION_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION GetMEDICATION_ADMINISTRATION_OBSERVATION(int rep) { 
	   return (CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION)this.GetStructure("MEDICATION_ADMINISTRATION_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION 
	 */ 
	public int MEDICATION_ADMINISTRATION_OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("MEDICATION_ADMINISTRATION_OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION results 
	 */ 
	public IEnumerable<CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION> MEDICATION_ADMINISTRATION_OBSERVATIONs 
	{ 
		get
		{
			for (int rep = 0; rep < MEDICATION_ADMINISTRATION_OBSERVATIONRepetitionsUsed; rep++)
			{
				yield return (CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION)this.GetStructure("MEDICATION_ADMINISTRATION_OBSERVATION", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION
	///</summary>
	public CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION AddMEDICATION_ADMINISTRATION_OBSERVATION()
	{
		return this.AddStructure("MEDICATION_ADMINISTRATION_OBSERVATION") as CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION;
	}

	///<summary>
	///Removes the given CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION
	///</summary>
	public void RemoveMEDICATION_ADMINISTRATION_OBSERVATION(CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION toRemove)
	{
		this.RemoveStructure("MEDICATION_ADMINISTRATION_OBSERVATION", toRemove);
	}

	///<summary>
	///Removes the CCI_I22_MEDICATION_ADMINISTRATION_OBSERVATION at the given index
	///</summary>
	public void RemoveMEDICATION_ADMINISTRATION_OBSERVATIONAt(int index)
	{
		this.RemoveRepetition("MEDICATION_ADMINISTRATION_OBSERVATION", index);
	}

}
}
