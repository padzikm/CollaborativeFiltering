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
	/// Generated by Infer.NET 2.6.41114.1 at 10:27 on 26 maja 2015.
	/// </remarks>
	public partial class Model90_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__91 property</summary>
		private Vector[] VVector__91;
		/// <summary>The number of iterations last computed by Changed_vVector__91. Set this to zero to force re-execution of Changed_vVector__91</summary>
		public int Changed_vVector__91_iterationsDone;
		public PointMass<Vector[]> vVector__91_marginal;
		/// <summary>Message to marginal of 'vVector273'</summary>
		public VectorGaussian vVector273_marginal_F;
		/// <summary>Message to marginal of 'vdouble__274'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__274_marginal_F;
		/// <summary>Message to marginal of 'vdouble__273'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__273_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__91'</summary>
		public Vector[] vVector__91
		{
			get {
				return this.VVector__91;
			}
			set {
				if ((value!=null)&&(value.Length!=1)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+1)+" was expected for variable \'vVector__91\'");
				}
				this.VVector__91 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__91_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__91") {
				return this.vVector__91;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__91") {
				this.vVector__91 = (Vector[])value;
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
			if (variableName=="vVector__91") {
				return this.VVector__91Marginal();
			}
			if (variableName=="vVector273") {
				return this.VVector273Marginal();
			}
			if (variableName=="vdouble__273") {
				return this.Vdouble__273Marginal();
			}
			if (variableName=="vdouble__274") {
				return this.Vdouble__274Marginal();
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
			this.Changed_vVector__91();
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

		/// <summary>Computations that depend on the observed value of vVector__91</summary>
		private void Changed_vVector__91()
		{
			if (this.Changed_vVector__91_iterationsDone==1) {
				return ;
			}
			this.vVector__91_marginal = new PointMass<Vector[]>(this.VVector__91);
			// The constant 'vVectorGaussian91'
			VectorGaussian vVectorGaussian91 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {1547829870.0, 525077980.0, 200270.0}), new PositiveDefiniteMatrix(new double[3, 3] {{4254590363351.0, 1127383488860.0, 433199230.0}, {1127383488860.0, 482723521821.0, 146764360.0}, {433199230.0, 146764360.0, 56221.0}}));
			this.vVector273_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian91);
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector273_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector273_rep' from Replicate factor
			vVector273_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian91);
			// Message to 'vVector273_marginal' from Variable factor
			this.vVector273_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector273_rep_B_toDef, vVectorGaussian91, this.vVector273_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__273_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__273' Forwards messages.
			vdouble__273_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index91 = 0; index91<1; index91++) {
				vdouble__273_F[index91] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__274_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__274' Forwards messages.
			vdouble__274_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index91 = 0; index91<1; index91++) {
				vdouble__274_F[index91] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector273_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			DistributionRefArray<VectorGaussian,Vector> vVector273_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector273_rep' Forwards messages.
			vVector273_rep_F = new DistributionRefArray<VectorGaussian,Vector>(1);
			// Create array for 'vVector273_rep' Backwards messages.
			vVector273_rep_B = new DistributionRefArray<VectorGaussian,Vector>(1);
			for(int index91 = 0; index91<1; index91++) {
				vVector273_rep_B[index91] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian91);
				vVector273_rep_F[index91] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian91);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector273_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector273_rep' from Replicate factor
			vVector273_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian91);
			// Message to 'vVector273_rep' from Replicate factor
			vVector273_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector273_rep_B_toDef, vVectorGaussian91, vVector273_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector273_rep_F_index91__AMean'
			Vector[] vVector273_rep_F_index91__AMean = new Vector[1];
			for(int index91 = 0; index91<1; index91++) {
				// Message to 'vdouble__274' from InnerProduct factor
				vVector273_rep_F_index91__AMean[index91] = InnerProductOp.AMeanInit(vVector273_rep_F[index91]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector273_rep_F_index91__AVariance'
			PositiveDefiniteMatrix[] vVector273_rep_F_index91__AVariance = new PositiveDefiniteMatrix[1];
			for(int index91 = 0; index91<1; index91++) {
				// Message to 'vdouble__274' from InnerProduct factor
				vVector273_rep_F_index91__AVariance[index91] = InnerProductOp.AVarianceInit(vVector273_rep_F[index91]);
				// Message to 'vVector273_rep' from Replicate factor
				vVector273_rep_F[index91] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector273_rep_B[index91], vVector273_rep_F_marginal, index91, vVector273_rep_F[index91]);
			}
			// Create array for 'vdouble__274_marginal' Forwards messages.
			this.vdouble__274_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index91 = 0; index91<1; index91++) {
				this.vdouble__274_marginal_F[index91] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__274'
			DistributionStructArray<Gaussian,double> vdouble__274_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__274_use' Backwards messages.
			vdouble__274_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index91 = 0; index91<1; index91++) {
				vdouble__274_use_B[index91] = Gaussian.Uniform();
				// Message to 'vdouble__274' from InnerProduct factor
				vVector273_rep_F_index91__AVariance[index91] = InnerProductOp.AVariance(vVector273_rep_F[index91], vVector273_rep_F_index91__AVariance[index91]);
				// Message to 'vdouble__274' from InnerProduct factor
				vVector273_rep_F_index91__AMean[index91] = InnerProductOp.AMean(vVector273_rep_F[index91], vVector273_rep_F_index91__AVariance[index91], vVector273_rep_F_index91__AMean[index91]);
				// Message to 'vdouble__274' from InnerProduct factor
				vdouble__274_F[index91] = InnerProductOp.InnerProductAverageConditional(vVector273_rep_F_index91__AMean[index91], vVector273_rep_F_index91__AVariance[index91], this.VVector__91[index91]);
				// Message to 'vdouble__274_marginal' from DerivedVariable factor
				this.vdouble__274_marginal_F[index91] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__274_use_B[index91], vdouble__274_F[index91], this.vdouble__274_marginal_F[index91]);
			}
			// Create array for 'vdouble__273_marginal' Forwards messages.
			this.vdouble__273_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index91 = 0; index91<1; index91++) {
				this.vdouble__273_marginal_F[index91] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__273'
			DistributionStructArray<Gaussian,double> vdouble__273_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__273_use' Backwards messages.
			vdouble__273_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index91 = 0; index91<1; index91++) {
				vdouble__273_use_B[index91] = Gaussian.Uniform();
				// Message to 'vdouble__273' from GaussianFromMeanAndVariance factor
				vdouble__273_F[index91] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__274_F[index91], 0.1);
				// Message to 'vdouble__273_marginal' from Variable factor
				this.vdouble__273_marginal_F[index91] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__273_use_B[index91], vdouble__273_F[index91], this.vdouble__273_marginal_F[index91]);
			}
			this.Changed_vVector__91_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__91' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__91Marginal()
		{
			return this.vVector__91_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector273' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector273Marginal()
		{
			return this.vVector273_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__273' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__273Marginal()
		{
			return this.vdouble__273_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__274' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__274Marginal()
		{
			return this.vdouble__274_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
