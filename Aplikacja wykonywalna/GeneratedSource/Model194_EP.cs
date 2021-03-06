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
	/// Generated by Infer.NET 2.6.41114.1 at 10:28 on 26 maja 2015.
	/// </remarks>
	public partial class Model194_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__195 property</summary>
		private Vector[] VVector__195;
		/// <summary>The number of iterations last computed by Changed_vVector__195. Set this to zero to force re-execution of Changed_vVector__195</summary>
		public int Changed_vVector__195_iterationsDone;
		public PointMass<Vector[]> vVector__195_marginal;
		/// <summary>Message to marginal of 'vVector585'</summary>
		public VectorGaussian vVector585_marginal_F;
		/// <summary>Message to marginal of 'vdouble__586'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__586_marginal_F;
		/// <summary>Message to marginal of 'vdouble__585'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__585_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__195'</summary>
		public Vector[] vVector__195
		{
			get {
				return this.VVector__195;
			}
			set {
				if ((value!=null)&&(value.Length!=1)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+1)+" was expected for variable \'vVector__195\'");
				}
				this.VVector__195 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__195_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__195") {
				return this.vVector__195;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__195") {
				this.vVector__195 = (Vector[])value;
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
			if (variableName=="vVector__195") {
				return this.VVector__195Marginal();
			}
			if (variableName=="vVector585") {
				return this.VVector585Marginal();
			}
			if (variableName=="vdouble__585") {
				return this.Vdouble__585Marginal();
			}
			if (variableName=="vdouble__586") {
				return this.Vdouble__586Marginal();
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
			this.Changed_vVector__195();
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

		/// <summary>Computations that depend on the observed value of vVector__195</summary>
		private void Changed_vVector__195()
		{
			if (this.Changed_vVector__195_iterationsDone==1) {
				return ;
			}
			this.vVector__195_marginal = new PointMass<Vector[]>(this.VVector__195);
			// The constant 'vVectorGaussian195'
			VectorGaussian vVectorGaussian195 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {1547829870.0, 525077980.0, 200270.0}), new PositiveDefiniteMatrix(new double[3, 3] {{4254590363351.0, 1127383488860.0, 433199230.0}, {1127383488860.0, 482723521821.0, 146764360.0}, {433199230.0, 146764360.0, 56221.0}}));
			this.vVector585_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian195);
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector585_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector585_rep' from Replicate factor
			vVector585_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian195);
			// Message to 'vVector585_marginal' from Variable factor
			this.vVector585_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector585_rep_B_toDef, vVectorGaussian195, this.vVector585_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__585_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__585' Forwards messages.
			vdouble__585_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index195 = 0; index195<1; index195++) {
				vdouble__585_F[index195] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__586_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__586' Forwards messages.
			vdouble__586_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index195 = 0; index195<1; index195++) {
				vdouble__586_F[index195] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector585_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			DistributionRefArray<VectorGaussian,Vector> vVector585_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector585_rep' Forwards messages.
			vVector585_rep_F = new DistributionRefArray<VectorGaussian,Vector>(1);
			// Create array for 'vVector585_rep' Backwards messages.
			vVector585_rep_B = new DistributionRefArray<VectorGaussian,Vector>(1);
			for(int index195 = 0; index195<1; index195++) {
				vVector585_rep_B[index195] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian195);
				vVector585_rep_F[index195] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian195);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector585_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector585_rep' from Replicate factor
			vVector585_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian195);
			// Message to 'vVector585_rep' from Replicate factor
			vVector585_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector585_rep_B_toDef, vVectorGaussian195, vVector585_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector585_rep_F_index195__AMean'
			Vector[] vVector585_rep_F_index195__AMean = new Vector[1];
			for(int index195 = 0; index195<1; index195++) {
				// Message to 'vdouble__586' from InnerProduct factor
				vVector585_rep_F_index195__AMean[index195] = InnerProductOp.AMeanInit(vVector585_rep_F[index195]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector585_rep_F_index195__AVariance'
			PositiveDefiniteMatrix[] vVector585_rep_F_index195__AVariance = new PositiveDefiniteMatrix[1];
			for(int index195 = 0; index195<1; index195++) {
				// Message to 'vdouble__586' from InnerProduct factor
				vVector585_rep_F_index195__AVariance[index195] = InnerProductOp.AVarianceInit(vVector585_rep_F[index195]);
				// Message to 'vVector585_rep' from Replicate factor
				vVector585_rep_F[index195] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector585_rep_B[index195], vVector585_rep_F_marginal, index195, vVector585_rep_F[index195]);
			}
			// Create array for 'vdouble__586_marginal' Forwards messages.
			this.vdouble__586_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index195 = 0; index195<1; index195++) {
				this.vdouble__586_marginal_F[index195] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__586'
			DistributionStructArray<Gaussian,double> vdouble__586_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__586_use' Backwards messages.
			vdouble__586_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index195 = 0; index195<1; index195++) {
				vdouble__586_use_B[index195] = Gaussian.Uniform();
				// Message to 'vdouble__586' from InnerProduct factor
				vVector585_rep_F_index195__AVariance[index195] = InnerProductOp.AVariance(vVector585_rep_F[index195], vVector585_rep_F_index195__AVariance[index195]);
				// Message to 'vdouble__586' from InnerProduct factor
				vVector585_rep_F_index195__AMean[index195] = InnerProductOp.AMean(vVector585_rep_F[index195], vVector585_rep_F_index195__AVariance[index195], vVector585_rep_F_index195__AMean[index195]);
				// Message to 'vdouble__586' from InnerProduct factor
				vdouble__586_F[index195] = InnerProductOp.InnerProductAverageConditional(vVector585_rep_F_index195__AMean[index195], vVector585_rep_F_index195__AVariance[index195], this.VVector__195[index195]);
				// Message to 'vdouble__586_marginal' from DerivedVariable factor
				this.vdouble__586_marginal_F[index195] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__586_use_B[index195], vdouble__586_F[index195], this.vdouble__586_marginal_F[index195]);
			}
			// Create array for 'vdouble__585_marginal' Forwards messages.
			this.vdouble__585_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index195 = 0; index195<1; index195++) {
				this.vdouble__585_marginal_F[index195] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__585'
			DistributionStructArray<Gaussian,double> vdouble__585_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__585_use' Backwards messages.
			vdouble__585_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index195 = 0; index195<1; index195++) {
				vdouble__585_use_B[index195] = Gaussian.Uniform();
				// Message to 'vdouble__585' from GaussianFromMeanAndVariance factor
				vdouble__585_F[index195] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__586_F[index195], 0.1);
				// Message to 'vdouble__585_marginal' from Variable factor
				this.vdouble__585_marginal_F[index195] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__585_use_B[index195], vdouble__585_F[index195], this.vdouble__585_marginal_F[index195]);
			}
			this.Changed_vVector__195_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__195' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__195Marginal()
		{
			return this.vVector__195_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector585' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector585Marginal()
		{
			return this.vVector585_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__585' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__585Marginal()
		{
			return this.vdouble__585_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__586' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__586Marginal()
		{
			return this.vdouble__586_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
