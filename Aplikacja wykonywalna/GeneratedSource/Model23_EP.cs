// <auto-generated />
#pragma warning disable 1570, 1591

using System;
using MicrosoftResearch.Infer;
using MicrosoftResearch.Infer.Maths;
using MicrosoftResearch.Infer.Distributions;
using MicrosoftResearch.Infer.Collections;
using MicrosoftResearch.Infer.Factors;

namespace MicrosoftResearch.Infer.Models.User
{
	/// <summary>
	/// Generated algorithm for performing inference.
	/// </summary>
	/// <remarks>
	/// If you wish to use this class directly, you must perform the following steps:
	/// 1) Create an instance of the class.
	/// 2) Set the value of any externally-set fields e.g. data, priors.
	/// 3) Call the Execute(numberOfIterations) method.
	/// 4) Use the XXXMarginal() methods to retrieve posterior marginals for different variables.
	/// 
	/// Generated by Infer.NET 2.6.41114.1 at 10:26 on 26 maja 2015.
	/// </remarks>
	public partial class Model23_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__24 property</summary>
		private Vector[] VVector__24;
		/// <summary>Field backing the vdouble__72 property</summary>
		private double[] Vdouble__72;
		/// <summary>The number of iterations last computed by Changed_vVector__24_vdouble__72. Set this to zero to force re-execution of Changed_vVector__24_vdouble__72</summary>
		public int Changed_vVector__24_vdouble__72_iterationsDone;
		public PointMass<Vector[]> vVector__24_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__72_marginal;
		/// <summary>Message to marginal of 'vVector73'</summary>
		public VectorGaussian vVector73_marginal_F;
		/// <summary>Message to marginal of 'vdouble__73'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__73_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__24'</summary>
		public Vector[] vVector__24
		{
			get {
				return this.VVector__24;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__24\'");
				}
				this.VVector__24 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__24_vdouble__72_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__72'</summary>
		public double[] vdouble__72
		{
			get {
				return this.Vdouble__72;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__72\'");
				}
				this.Vdouble__72 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__24_vdouble__72_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__24") {
				return this.vVector__24;
			}
			if (variableName=="vdouble__72") {
				return this.vdouble__72;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__24") {
				this.vVector__24 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__72") {
				this.vdouble__72 = (double[])value;
				return ;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName)
		{
			if (variableName=="vVector__24") {
				return this.VVector__24Marginal();
			}
			if (variableName=="vdouble__72") {
				return this.Vdouble__72Marginal();
			}
			if (variableName=="vVector73") {
				return this.VVector73Marginal();
			}
			if (variableName=="vdouble__73") {
				return this.Vdouble__73Marginal();
			}
			throw new ArgumentException("This class was not built to infer "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName));
		}

		/// <summary>Get the query-specific marginal distribution of a variable.</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName, string query)
		{
			if (query=="Marginal") {
				return this.Marginal(variableName);
			}
			throw new ArgumentException(((("This class was not built to infer \'"+variableName)+"\' with query \'")+query)+"\'");
		}

		/// <summary>Get the query-specific marginal distribution of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName, string query)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName, query));
		}

		/// <summary>Update all marginals, by iterating message passing the given number of times</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		/// <param name="initialise">If true, messages that initialise loops are reset when observed values change</param>
		private void Execute(int numberOfIterations, bool initialise)
		{
			this.Changed_vVector__24_vdouble__72();
			this.numberOfIterationsDone = numberOfIterations;
		}

		/// <summary>Update all marginals, by iterating message-passing the given number of times</summary>
		/// <param name="numberOfIterations">The total number of iterations that should be executed for the current set of observed values.  If this is more than the number already done, only the extra iterations are done.  If this is less than the number already done, message-passing is restarted from the beginning.  Changing the observed values resets the iteration count to 0.</param>
		public void Execute(int numberOfIterations)
		{
			this.Execute(numberOfIterations, true);
		}

		/// <summary>Update all marginals, by iterating message-passing an additional number of times</summary>
		/// <param name="additionalIterations">The number of iterations that should be executed, starting from the current message state.  Messages are not reset, even if observed values have changed.</param>
		public void Update(int additionalIterations)
		{
			this.Execute(this.numberOfIterationsDone+additionalIterations, false);
		}

		private void OnProgressChanged(ProgressChangedEventArgs e)
		{
			// Make a temporary copy of the event to avoid a race condition
			// if the last subscriber unsubscribes immediately after the null check and before the event is raised.
			EventHandler<ProgressChangedEventArgs> handler = this.ProgressChanged;
			if (handler!=null) {
				handler(this, e);
			}
		}

		/// <summary>Reset all messages to their initial values.  Sets NumberOfIterationsDone to 0.</summary>
		public void Reset()
		{
			this.Execute(0);
		}

		/// <summary>Computations that depend on the observed value of vVector__24 and vdouble__72</summary>
		private void Changed_vVector__24_vdouble__72()
		{
			if (this.Changed_vVector__24_vdouble__72_iterationsDone==1) {
				return ;
			}
			this.vVector__24_marginal = new PointMass<Vector[]>(this.VVector__24);
			this.vdouble__72_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index24) {
				return Gaussian.Uniform();
			});
			this.vdouble__72_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__72_marginal, this.Vdouble__72);
			// The constant 'vVectorGaussian24'
			VectorGaussian vVectorGaussian24 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector73_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian24);
			// Message from use of 'vdouble__73'
			DistributionStructArray<Gaussian,double> vdouble__73_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__73_use' Backwards messages.
			vdouble__73_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index24 = 0; index24<5622; index24++) {
				vdouble__73_use_B[index24] = Gaussian.Uniform();
				// Message to 'vdouble__73_use' from GaussianFromMeanAndVariance factor
				vdouble__73_use_B[index24] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__72[index24], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector73_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector73_rep' Backwards messages.
			vVector73_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index24 = 0; index24<5622; index24++) {
				vVector73_rep_B[index24] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian24);
				// Message to 'vVector73_rep' from InnerProduct factor
				vVector73_rep_B[index24] = InnerProductOp.AAverageConditional(vdouble__73_use_B[index24], this.VVector__24[index24], vVector73_rep_B[index24]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector73_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector73_rep' from Replicate factor
			vVector73_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian24);
			// Message to 'vVector73_rep' from Replicate factor
			vVector73_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector73_rep_B, vVector73_rep_B_toDef);
			// Message to 'vVector73_marginal' from Variable factor
			this.vVector73_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector73_rep_B_toDef, vVectorGaussian24, this.vVector73_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__73_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__73' Forwards messages.
			vdouble__73_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index24 = 0; index24<5622; index24++) {
				vdouble__73_F[index24] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector73_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector73_rep' Forwards messages.
			vVector73_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index24 = 0; index24<5622; index24++) {
				vVector73_rep_F[index24] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian24);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector73_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector73_rep' from Replicate factor
			vVector73_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian24);
			// Message to 'vVector73_rep' from Replicate factor
			vVector73_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector73_rep_B_toDef, vVectorGaussian24, vVector73_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector73_rep_F_index24__AMean'
			Vector[] vVector73_rep_F_index24__AMean = new Vector[5622];
			for(int index24 = 0; index24<5622; index24++) {
				// Message to 'vdouble__73' from InnerProduct factor
				vVector73_rep_F_index24__AMean[index24] = InnerProductOp.AMeanInit(vVector73_rep_F[index24]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector73_rep_F_index24__AVariance'
			PositiveDefiniteMatrix[] vVector73_rep_F_index24__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index24 = 0; index24<5622; index24++) {
				// Message to 'vdouble__73' from InnerProduct factor
				vVector73_rep_F_index24__AVariance[index24] = InnerProductOp.AVarianceInit(vVector73_rep_F[index24]);
				// Message to 'vVector73_rep' from Replicate factor
				vVector73_rep_F[index24] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector73_rep_B[index24], vVector73_rep_F_marginal, index24, vVector73_rep_F[index24]);
			}
			// Create array for 'vdouble__73_marginal' Forwards messages.
			this.vdouble__73_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index24 = 0; index24<5622; index24++) {
				this.vdouble__73_marginal_F[index24] = Gaussian.Uniform();
				// Message to 'vdouble__73' from InnerProduct factor
				vVector73_rep_F_index24__AVariance[index24] = InnerProductOp.AVariance(vVector73_rep_F[index24], vVector73_rep_F_index24__AVariance[index24]);
				// Message to 'vdouble__73' from InnerProduct factor
				vVector73_rep_F_index24__AMean[index24] = InnerProductOp.AMean(vVector73_rep_F[index24], vVector73_rep_F_index24__AVariance[index24], vVector73_rep_F_index24__AMean[index24]);
				// Message to 'vdouble__73' from InnerProduct factor
				vdouble__73_F[index24] = InnerProductOp.InnerProductAverageConditional(vVector73_rep_F_index24__AMean[index24], vVector73_rep_F_index24__AVariance[index24], this.VVector__24[index24]);
				// Message to 'vdouble__73_marginal' from DerivedVariable factor
				this.vdouble__73_marginal_F[index24] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__73_use_B[index24], vdouble__73_F[index24], this.vdouble__73_marginal_F[index24]);
			}
			this.Changed_vVector__24_vdouble__72_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__24' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__24Marginal()
		{
			return this.vVector__24_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__72' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__72Marginal()
		{
			return this.vdouble__72_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector73' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector73Marginal()
		{
			return this.vVector73_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__73' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__73Marginal()
		{
			return this.vdouble__73_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}