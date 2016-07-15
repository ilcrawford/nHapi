using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
///<summary>
///Represents the CSU_C09_PATIENT Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: PID (PID - patient identification segment) </li>
///<li>1: PD1 (PD1 - patient additional demographic segment) optional </li>
///<li>2: NTE (NTE - notes and comments segment) optional repeating</li>
///<li>3: CSU_C09_VISIT (a Group object) optional </li>
///<li>4: CSR (CSR - clinical study registration segment) </li>
///<li>5: CSU_C09_STUDY_PHASE (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class CSU_C09_PATIENT : AbstractGroup {

	///<summary> 
	/// Creates a new CSU_C09_PATIENT Group.
	///</summary>
	public CSU_C09_PATIENT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PID), true, false);
	      this.add(typeof(PD1), false, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(CSU_C09_VISIT), false, false);
	      this.add(typeof(CSR), true, false);
	      this.add(typeof(CSU_C09_STUDY_PHASE), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating CSU_C09_PATIENT - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns PID (PID - patient identification segment) - creates it if necessary
	///</summary>
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.GetStructure("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary
	///</summary>
	public PD1 PD1 { 
get{
	   PD1 ret = null;
	   try {
	      ret = (PD1)this.GetStructure("PD1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (NTE - notes and comments segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

	///<summary>
	/// Returns CSU_C09_VISIT (a Group object) - creates it if necessary
	///</summary>
	public CSU_C09_VISIT VISIT { 
get{
	   CSU_C09_VISIT ret = null;
	   try {
	      ret = (CSU_C09_VISIT)this.GetStructure("VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns CSR (CSR - clinical study registration segment) - creates it if necessary
	///</summary>
	public CSR CSR { 
get{
	   CSR ret = null;
	   try {
	      ret = (CSR)this.GetStructure("CSR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of CSU_C09_STUDY_PHASE (a Group object) - creates it if necessary
	///</summary>
	public CSU_C09_STUDY_PHASE GetSTUDY_PHASE() {
	   CSU_C09_STUDY_PHASE ret = null;
	   try {
	      ret = (CSU_C09_STUDY_PHASE)this.GetStructure("STUDY_PHASE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CSU_C09_STUDY_PHASE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CSU_C09_STUDY_PHASE GetSTUDY_PHASE(int rep) { 
	   return (CSU_C09_STUDY_PHASE)this.GetStructure("STUDY_PHASE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSU_C09_STUDY_PHASE 
	 */ 
	public int STUDY_PHASERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("STUDY_PHASE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CSU_C09_STUDY_PHASE results 
	 */ 
	public IEnumerable<CSU_C09_STUDY_PHASE> STUDY_PHASEs 
	{ 
		get
		{
			for (int rep = 0; rep < STUDY_PHASERepetitionsUsed; rep++)
			{
				yield return (CSU_C09_STUDY_PHASE)this.GetStructure("STUDY_PHASE", rep);
			}
		}
	}

	///<summary>
	///Adds a new CSU_C09_STUDY_PHASE
	///</summary>
	public CSU_C09_STUDY_PHASE AddSTUDY_PHASE()
	{
		return this.AddStructure("STUDY_PHASE") as CSU_C09_STUDY_PHASE;
	}

	///<summary>
	///Removes the given CSU_C09_STUDY_PHASE
	///</summary>
	public void RemoveSTUDY_PHASE(CSU_C09_STUDY_PHASE toRemove)
	{
		this.RemoveStructure("STUDY_PHASE", toRemove);
	}

	///<summary>
	///Removes the CSU_C09_STUDY_PHASE at the given index
	///</summary>
	public void RemoveSTUDY_PHASEAt(int index)
	{
		this.RemoveRepetition("STUDY_PHASE", index);
	}

}
}
