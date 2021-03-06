using System;
using System.Collections.Generic;
using NHapi.Base.Log;
using NHapi.Model.V281.Group;
using NHapi.Model.V281.Segment;
using NHapi.Model.V281.Datatype;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V281.Message

{
///<summary>
/// Represents a EHC_E12 message structure (see chapter 16.3.7). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (Message Header) </li>
///<li>1: SFT (Software Segment) optional repeating</li>
///<li>2: UAC (User Authentication Credential Segment) optional repeating</li>
///<li>3: RFI (Request for Information) </li>
///<li>4: CTD (Contact Data) optional repeating</li>
///<li>5: IVC (Invoice Segment) </li>
///<li>6: PSS (Product/Service Section) </li>
///<li>7: PSG (Product/Service Group) </li>
///<li>8: PID (Patient Identification) optional </li>
///<li>9: PSL (Product/Service Line Item) optional repeating</li>
///<li>10: EHC_E12_REQUEST (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class EHC_E12 : AbstractMessage  {

	///<summary> 
	/// Creates a new EHC_E12 Group with custom IModelClassFactory.
	///</summary>
	public EHC_E12(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new EHC_E12 Group with DefaultModelClassFactory. 
	///</summary> 
	public EHC_E12() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for EHC_E12.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SFT), false, true);
	      this.add(typeof(UAC), false, true);
	      this.add(typeof(RFI), true, false);
	      this.add(typeof(CTD), false, true);
	      this.add(typeof(IVC), true, false);
	      this.add(typeof(PSS), true, false);
	      this.add(typeof(PSG), true, false);
	      this.add(typeof(PID), false, false);
	      this.add(typeof(PSL), false, true);
	      this.add(typeof(EHC_E12_REQUEST), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating EHC_E12 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (Message Header) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of SFT (Software Segment) - creates it if necessary
	///</summary>
	public SFT GetSFT() {
	   SFT ret = null;
	   try {
	      ret = (SFT)this.GetStructure("SFT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SFT
	/// * (Software Segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SFT GetSFT(int rep) { 
	   return (SFT)this.GetStructure("SFT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SFT 
	 */ 
	public int SFTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SFT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the SFT results 
	 */ 
	public IEnumerable<SFT> SFTs 
	{ 
		get
		{
			for (int rep = 0; rep < SFTRepetitionsUsed; rep++)
			{
				yield return (SFT)this.GetStructure("SFT", rep);
			}
		}
	}

	///<summary>
	///Adds a new SFT
	///</summary>
	public SFT AddSFT()
	{
		return this.AddStructure("SFT") as SFT;
	}

	///<summary>
	///Removes the given SFT
	///</summary>
	public void RemoveSFT(SFT toRemove)
	{
		this.RemoveStructure("SFT", toRemove);
	}

	///<summary>
	///Removes the SFT at the given index
	///</summary>
	public void RemoveSFTAt(int index)
	{
		this.RemoveRepetition("SFT", index);
	}

	///<summary>
	/// Returns  first repetition of UAC (User Authentication Credential Segment) - creates it if necessary
	///</summary>
	public UAC GetUAC() {
	   UAC ret = null;
	   try {
	      ret = (UAC)this.GetStructure("UAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of UAC
	/// * (User Authentication Credential Segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public UAC GetUAC(int rep) { 
	   return (UAC)this.GetStructure("UAC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of UAC 
	 */ 
	public int UACRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("UAC").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the UAC results 
	 */ 
	public IEnumerable<UAC> UACs 
	{ 
		get
		{
			for (int rep = 0; rep < UACRepetitionsUsed; rep++)
			{
				yield return (UAC)this.GetStructure("UAC", rep);
			}
		}
	}

	///<summary>
	///Adds a new UAC
	///</summary>
	public UAC AddUAC()
	{
		return this.AddStructure("UAC") as UAC;
	}

	///<summary>
	///Removes the given UAC
	///</summary>
	public void RemoveUAC(UAC toRemove)
	{
		this.RemoveStructure("UAC", toRemove);
	}

	///<summary>
	///Removes the UAC at the given index
	///</summary>
	public void RemoveUACAt(int index)
	{
		this.RemoveRepetition("UAC", index);
	}

	///<summary>
	/// Returns RFI (Request for Information) - creates it if necessary
	///</summary>
	public RFI RFI { 
get{
	   RFI ret = null;
	   try {
	      ret = (RFI)this.GetStructure("RFI");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of CTD (Contact Data) - creates it if necessary
	///</summary>
	public CTD GetCTD() {
	   CTD ret = null;
	   try {
	      ret = (CTD)this.GetStructure("CTD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CTD
	/// * (Contact Data) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CTD GetCTD(int rep) { 
	   return (CTD)this.GetStructure("CTD", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CTD 
	 */ 
	public int CTDRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CTD").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CTD results 
	 */ 
	public IEnumerable<CTD> CTDs 
	{ 
		get
		{
			for (int rep = 0; rep < CTDRepetitionsUsed; rep++)
			{
				yield return (CTD)this.GetStructure("CTD", rep);
			}
		}
	}

	///<summary>
	///Adds a new CTD
	///</summary>
	public CTD AddCTD()
	{
		return this.AddStructure("CTD") as CTD;
	}

	///<summary>
	///Removes the given CTD
	///</summary>
	public void RemoveCTD(CTD toRemove)
	{
		this.RemoveStructure("CTD", toRemove);
	}

	///<summary>
	///Removes the CTD at the given index
	///</summary>
	public void RemoveCTDAt(int index)
	{
		this.RemoveRepetition("CTD", index);
	}

	///<summary>
	/// Returns IVC (Invoice Segment) - creates it if necessary
	///</summary>
	public IVC IVC { 
get{
	   IVC ret = null;
	   try {
	      ret = (IVC)this.GetStructure("IVC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PSS (Product/Service Section) - creates it if necessary
	///</summary>
	public PSS PSS { 
get{
	   PSS ret = null;
	   try {
	      ret = (PSS)this.GetStructure("PSS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PSG (Product/Service Group) - creates it if necessary
	///</summary>
	public PSG PSG { 
get{
	   PSG ret = null;
	   try {
	      ret = (PSG)this.GetStructure("PSG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PID (Patient Identification) - creates it if necessary
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
	/// Returns  first repetition of PSL (Product/Service Line Item) - creates it if necessary
	///</summary>
	public PSL GetPSL() {
	   PSL ret = null;
	   try {
	      ret = (PSL)this.GetStructure("PSL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PSL
	/// * (Product/Service Line Item) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PSL GetPSL(int rep) { 
	   return (PSL)this.GetStructure("PSL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PSL 
	 */ 
	public int PSLRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PSL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the PSL results 
	 */ 
	public IEnumerable<PSL> PSLs 
	{ 
		get
		{
			for (int rep = 0; rep < PSLRepetitionsUsed; rep++)
			{
				yield return (PSL)this.GetStructure("PSL", rep);
			}
		}
	}

	///<summary>
	///Adds a new PSL
	///</summary>
	public PSL AddPSL()
	{
		return this.AddStructure("PSL") as PSL;
	}

	///<summary>
	///Removes the given PSL
	///</summary>
	public void RemovePSL(PSL toRemove)
	{
		this.RemoveStructure("PSL", toRemove);
	}

	///<summary>
	///Removes the PSL at the given index
	///</summary>
	public void RemovePSLAt(int index)
	{
		this.RemoveRepetition("PSL", index);
	}

	///<summary>
	/// Returns  first repetition of EHC_E12_REQUEST (a Group object) - creates it if necessary
	///</summary>
	public EHC_E12_REQUEST GetREQUEST() {
	   EHC_E12_REQUEST ret = null;
	   try {
	      ret = (EHC_E12_REQUEST)this.GetStructure("REQUEST");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of EHC_E12_REQUEST
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public EHC_E12_REQUEST GetREQUEST(int rep) { 
	   return (EHC_E12_REQUEST)this.GetStructure("REQUEST", rep);
	}

	/** 
	 * Returns the number of existing repetitions of EHC_E12_REQUEST 
	 */ 
	public int REQUESTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("REQUEST").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the EHC_E12_REQUEST results 
	 */ 
	public IEnumerable<EHC_E12_REQUEST> REQUESTs 
	{ 
		get
		{
			for (int rep = 0; rep < REQUESTRepetitionsUsed; rep++)
			{
				yield return (EHC_E12_REQUEST)this.GetStructure("REQUEST", rep);
			}
		}
	}

	///<summary>
	///Adds a new EHC_E12_REQUEST
	///</summary>
	public EHC_E12_REQUEST AddREQUEST()
	{
		return this.AddStructure("REQUEST") as EHC_E12_REQUEST;
	}

	///<summary>
	///Removes the given EHC_E12_REQUEST
	///</summary>
	public void RemoveREQUEST(EHC_E12_REQUEST toRemove)
	{
		this.RemoveStructure("REQUEST", toRemove);
	}

	///<summary>
	///Removes the EHC_E12_REQUEST at the given index
	///</summary>
	public void RemoveREQUESTAt(int index)
	{
		this.RemoveRepetition("REQUEST", index);
	}

}
}
