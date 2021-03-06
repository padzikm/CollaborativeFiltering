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
	public partial class Model30_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__31 property</summary>
		private Vector[] VVector__31;
		/// <summary>The number of iterations last computed by Changed_vVector__31. Set this to zero to force re-execution of Changed_vVector__31</summary>
		public int Changed_vVector__31_iterationsDone;
		public PointMass<Vector[]> vVector__31_marginal;
		/// <summary>Message to marginal of 'vVector93'</summary>
		public VectorGaussian vVector93_marginal_F;
		/// <summary>Message to marginal of 'vdouble__94'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__94_marginal_F;
		/// <summary>Message to marginal of 'vdouble__93'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__93_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__31'</summary>
		public Vector[] vVector__31
		{
			get {
				return this.VVector__31;
			}
			set {
				if ((value!=null)&&(value.Length!=1)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+1)+" was expected for variable \'vVector__31\'");
				}
				this.VVector__31 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__31_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__31") {
				return this.vVector__31;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__31") {
				this.vVector__31 = (Vector[])value;
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
			if (variableName=="vVector__31") {
				return this.VVector__31Marginal();
			}
			if (variableName=="vVector93") {
				return this.VVector93Marginal();
			}
			if (variableName=="vdouble__93") {
				return this.Vdouble__93Marginal();
			}
			if (variableName=="vdouble__94") {
				return this.Vdouble__94Marginal();
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
			this.Changed_vVector__31();
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

		/// <summary>Computations that depend on the observed value of vVector__31</summary>
		private void Changed_vVector__31()
		{
			if (this.Changed_vVector__31_iterationsDone==1) {
				return ;
			}
			this.vVector__31_marginal = new PointMass<Vector[]>(this.VVector__31);
			// The constant 'vVectorGaussian31'
			VectorGaussian vVectorGaussian31 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {1547829870.0, 525077980.0, 200270.0}), new PositiveDefiniteMatrix(new double[3, 3] {{4254590363351.0, 1127383488860.0, 433199230.0}, {1127383488860.0, 482723521821.0, 146764360.0}, {433199230.0, 146764360.0, 56221.0}}));
			this.vVector93_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian31);
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector93_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector93_rep' from Replicate factor
			vVector93_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian31);
			// Message to 'vVector93_marginal' from Variable factor
			this.vVector93_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector93_rep_B_toDef, vVectorGaussian31, this.vVector93_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__93_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__93' Forwards messages.
			vdouble__93_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index31 = 0; index31<1; index31++) {
				vdouble__93_F[index31] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__94_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__94' Forwards messages.
			vdouble__94_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index31 = 0; index31<1; index31++) {
				vdouble__94_F[index31] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector93_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			DistributionRefArray<VectorGaussian,Vector> vVector93_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector93_rep' Forwards messages.
			vVector93_rep_F = new DistributionRefArray<VectorGaussian,Vector>(1);
			// Create array for 'vVector93_rep' Backwards messages.
			vVector93_rep_B = new DistributionRefArray<VectorGaussian,Vector>(1);
			for(int index31 = 0; index31<1; index31++) {
				vVector93_rep_B[index31] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian31);
				vVector93_rep_F[index31] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian31);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector93_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector93_rep' from Replicate factor
			vVector93_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian31);
			// Message to 'vVector93_rep' from Replicate factor
			vVector93_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector93_rep_B_toDef, vVectorGaussian31, vVector93_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector93_rep_F_index31__AMean'
			Vector[] vVector93_rep_F_index31__AMean = new Vector[1];
			for(int index31 = 0; index31<1; index31++) {
				// Message to 'vdouble__94' from InnerProduct factor
				vVector93_rep_F_index31__AMean[index31] = InnerProductOp.AMeanInit(vVector93_rep_F[index31]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector93_rep_F_index31__AVariance'
			PositiveDefiniteMatrix[] vVector93_rep_F_index31__AVariance = new PositiveDefiniteMatrix[1];
			for(int index31 = 0; index31<1; index31++) {
				// Message to 'vdouble__94' from InnerProduct factor
				vVector93_rep_F_index31__AVariance[index31] = InnerProductOp.AVarianceInit(vVector93_rep_F[index31]);
				// Message to 'vVector93_rep' from Replicate factor
				vVector93_rep_F[index31] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector93_rep_B[index31], vVector93_rep_F_marginal, index31, vVector93_rep_F[index31]);
			}
			// Create array for 'vdouble__94_marginal' Forwards messages.
			this.vdouble__94_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index31 = 0; index31<1; index31++) {
				this.vdouble__94_marginal_F[index31] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__94'
			DistributionStructArray<Gaussian,double> vdouble__94_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__94_use' Backwards messages.
			vdouble__94_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index31 = 0; index31<1; index31++) {
				vdouble__94_use_B[index31] = Gaussian.Uniform();
				// Message to 'vdouble__94' from InnerProduct factor
				vVector93_rep_F_index31__AVariance[index31] = InnerProductOp.AVariance(vVector93_rep_F[index31], vVector93_rep_F_index31__AVariance[index31]);
				// Message to 'vdouble__94' from InnerProduct factor
				vVector93_rep_F_index31__AMean[index31] = InnerProductOp.AMean(vVector93_rep_F[index31], vVector93_rep_F_index31__AVariance[index31], vVector93_rep_F_index31__AMean[index31]);
				// Message to 'vdouble__94' from InnerProduct factor
				vdouble__94_F[index31] = InnerProductOp.InnerProductAverageConditional(vVector93_rep_F_index31__AMean[index31], vVector93_rep_F_index31__AVariance[index31], this.VVector__31[index31]);
				// Message to 'vdouble__94_marginal' from DerivedVariable factor
				this.vdouble__94_marginal_F[index31] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__94_use_B[index31], vdouble__94_F[index31], this.vdouble__94_marginal_F[index31]);
			}
			// Create array for 'vdouble__93_marginal' Forwards messages.
			this.vdouble__93_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index31 = 0; index31<1; index31++) {
				this.vdouble__93_marginal_F[index31] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__93'
			DistributionStructArray<Gaussian,double> vdouble__93_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__93_use' Backwards messages.
			vdouble__93_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index31 = 0; index31<1; index31++) {
				vdouble__93_use_B[index31] = Gaussian.Uniform();
				// Message to 'vdouble__93' from GaussianFromMeanAndVariance factor
				vdouble__93_F[index31] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__94_F[index31], 0.1);
				// Message to 'vdouble__93_marginal' from Variable factor
				this.vdouble__93_marginal_F[index31] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__93_use_B[index31], vdouble__93_F[index31], this.vdouble__93_marginal_F[index31]);
			}
			this.Changed_vVector__31_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__31' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__31Marginal()
		{
			return this.vVector__31_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector93' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector93Marginal()
		{
			return this.vVector93_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__93' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__93Marginal()
		{
			return this.vdouble__93_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__94' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__94Marginal()
		{
			return this.vdouble__94_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
