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
	/// Generated by Infer.NET 2.6.41114.1 at 10:29 on 26 maja 2015.
	/// </remarks>
	public partial class Model342_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__343 property</summary>
		private Vector[] VVector__343;
		/// <summary>The number of iterations last computed by Changed_vVector__343. Set this to zero to force re-execution of Changed_vVector__343</summary>
		public int Changed_vVector__343_iterationsDone;
		public PointMass<Vector[]> vVector__343_marginal;
		/// <summary>Message to marginal of 'vVector1029'</summary>
		public VectorGaussian vVector1029_marginal_F;
		/// <summary>Message to marginal of 'vdouble__1030'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__1030_marginal_F;
		/// <summary>Message to marginal of 'vdouble__1029'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__1029_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__343'</summary>
		public Vector[] vVector__343
		{
			get {
				return this.VVector__343;
			}
			set {
				if ((value!=null)&&(value.Length!=1)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+1)+" was expected for variable \'vVector__343\'");
				}
				this.VVector__343 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__343_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__343") {
				return this.vVector__343;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__343") {
				this.vVector__343 = (Vector[])value;
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
			if (variableName=="vVector__343") {
				return this.VVector__343Marginal();
			}
			if (variableName=="vVector1029") {
				return this.VVector1029Marginal();
			}
			if (variableName=="vdouble__1029") {
				return this.Vdouble__1029Marginal();
			}
			if (variableName=="vdouble__1030") {
				return this.Vdouble__1030Marginal();
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
			this.Changed_vVector__343();
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

		/// <summary>Computations that depend on the observed value of vVector__343</summary>
		private void Changed_vVector__343()
		{
			if (this.Changed_vVector__343_iterationsDone==1) {
				return ;
			}
			this.vVector__343_marginal = new PointMass<Vector[]>(this.VVector__343);
			// The constant 'vVectorGaussian343'
			VectorGaussian vVectorGaussian343 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {1547829870.0, 525077980.0, 200270.0}), new PositiveDefiniteMatrix(new double[3, 3] {{4254590363351.0, 1127383488860.0, 433199230.0}, {1127383488860.0, 482723521821.0, 146764360.0}, {433199230.0, 146764360.0, 56221.0}}));
			this.vVector1029_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian343);
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector1029_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector1029_rep' from Replicate factor
			vVector1029_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian343);
			// Message to 'vVector1029_marginal' from Variable factor
			this.vVector1029_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector1029_rep_B_toDef, vVectorGaussian343, this.vVector1029_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__1029_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__1029' Forwards messages.
			vdouble__1029_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index343 = 0; index343<1; index343++) {
				vdouble__1029_F[index343] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__1030_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__1030' Forwards messages.
			vdouble__1030_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index343 = 0; index343<1; index343++) {
				vdouble__1030_F[index343] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector1029_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			DistributionRefArray<VectorGaussian,Vector> vVector1029_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector1029_rep' Forwards messages.
			vVector1029_rep_F = new DistributionRefArray<VectorGaussian,Vector>(1);
			// Create array for 'vVector1029_rep' Backwards messages.
			vVector1029_rep_B = new DistributionRefArray<VectorGaussian,Vector>(1);
			for(int index343 = 0; index343<1; index343++) {
				vVector1029_rep_B[index343] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian343);
				vVector1029_rep_F[index343] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian343);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector1029_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector1029_rep' from Replicate factor
			vVector1029_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian343);
			// Message to 'vVector1029_rep' from Replicate factor
			vVector1029_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector1029_rep_B_toDef, vVectorGaussian343, vVector1029_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector1029_rep_F_index343__AMean'
			Vector[] vVector1029_rep_F_index343__AMean = new Vector[1];
			for(int index343 = 0; index343<1; index343++) {
				// Message to 'vdouble__1030' from InnerProduct factor
				vVector1029_rep_F_index343__AMean[index343] = InnerProductOp.AMeanInit(vVector1029_rep_F[index343]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector1029_rep_F_index343__AVariance'
			PositiveDefiniteMatrix[] vVector1029_rep_F_index343__AVariance = new PositiveDefiniteMatrix[1];
			for(int index343 = 0; index343<1; index343++) {
				// Message to 'vdouble__1030' from InnerProduct factor
				vVector1029_rep_F_index343__AVariance[index343] = InnerProductOp.AVarianceInit(vVector1029_rep_F[index343]);
				// Message to 'vVector1029_rep' from Replicate factor
				vVector1029_rep_F[index343] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector1029_rep_B[index343], vVector1029_rep_F_marginal, index343, vVector1029_rep_F[index343]);
			}
			// Create array for 'vdouble__1030_marginal' Forwards messages.
			this.vdouble__1030_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index343 = 0; index343<1; index343++) {
				this.vdouble__1030_marginal_F[index343] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__1030'
			DistributionStructArray<Gaussian,double> vdouble__1030_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__1030_use' Backwards messages.
			vdouble__1030_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index343 = 0; index343<1; index343++) {
				vdouble__1030_use_B[index343] = Gaussian.Uniform();
				// Message to 'vdouble__1030' from InnerProduct factor
				vVector1029_rep_F_index343__AVariance[index343] = InnerProductOp.AVariance(vVector1029_rep_F[index343], vVector1029_rep_F_index343__AVariance[index343]);
				// Message to 'vdouble__1030' from InnerProduct factor
				vVector1029_rep_F_index343__AMean[index343] = InnerProductOp.AMean(vVector1029_rep_F[index343], vVector1029_rep_F_index343__AVariance[index343], vVector1029_rep_F_index343__AMean[index343]);
				// Message to 'vdouble__1030' from InnerProduct factor
				vdouble__1030_F[index343] = InnerProductOp.InnerProductAverageConditional(vVector1029_rep_F_index343__AMean[index343], vVector1029_rep_F_index343__AVariance[index343], this.VVector__343[index343]);
				// Message to 'vdouble__1030_marginal' from DerivedVariable factor
				this.vdouble__1030_marginal_F[index343] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__1030_use_B[index343], vdouble__1030_F[index343], this.vdouble__1030_marginal_F[index343]);
			}
			// Create array for 'vdouble__1029_marginal' Forwards messages.
			this.vdouble__1029_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index343 = 0; index343<1; index343++) {
				this.vdouble__1029_marginal_F[index343] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__1029'
			DistributionStructArray<Gaussian,double> vdouble__1029_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__1029_use' Backwards messages.
			vdouble__1029_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index343 = 0; index343<1; index343++) {
				vdouble__1029_use_B[index343] = Gaussian.Uniform();
				// Message to 'vdouble__1029' from GaussianFromMeanAndVariance factor
				vdouble__1029_F[index343] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__1030_F[index343], 0.1);
				// Message to 'vdouble__1029_marginal' from Variable factor
				this.vdouble__1029_marginal_F[index343] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__1029_use_B[index343], vdouble__1029_F[index343], this.vdouble__1029_marginal_F[index343]);
			}
			this.Changed_vVector__343_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__343' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__343Marginal()
		{
			return this.vVector__343_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector1029' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector1029Marginal()
		{
			return this.vVector1029_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__1029' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__1029Marginal()
		{
			return this.vdouble__1029_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__1030' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__1030Marginal()
		{
			return this.vdouble__1030_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}