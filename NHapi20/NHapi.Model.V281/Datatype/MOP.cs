using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V281.Datatype
{

///<summary>
/// <p>The HL7 MOP (Money or Percentage) data type.  Consists of the following components: </p><ol>
/// <li>Money or Percentage Indicator (ID)</li>
/// <li>Money or Percentage Quantity (NM)</li>
/// <li>Monetary  Denomination (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class MOP : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a MOP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public MOP(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a MOP.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public MOP(IMessage message, string description) : base(message, description){
		data = new IType[3];
		data[0] = new ID(message, 148,"Money or Percentage Indicator");
		data[1] = new NM(message,"Money or Percentage Quantity");
		data[2] = new ID(message, 913,"Monetary  Denomination");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public IType[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="index">The index item to get (zero based)</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///</summary>
	public IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 3 element MOP composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns Money or Percentage Indicator (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID MoneyOrPercentageIndicator {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Money or Percentage Quantity (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM MoneyOrPercentageQuantity {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Monetary  Denomination (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID MonetaryDenomination {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}