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
	public partial class Model208_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__209 property</summary>
		private Vector[] VVector__209;
		/// <summary>The number of iterations last computed by Changed_vVector__209. Set this to zero to force re-execution of Changed_vVector__209</summary>
		public int Changed_vVector__209_iterationsDone;
		public PointMass<Vector[]> vVector__209_marginal;
		/// <summary>Message to marginal of 'vVector627'</summary>
		public VectorGaussian vVector627_marginal_F;
		/// <summary>Message to marginal of 'vdouble__628'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__628_marginal_F;
		/// <summary>Message to marginal of 'vdouble__627'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__627_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__209'</summary>
		public Vector[] vVector__209
		{
			get {
				return this.VVector__209;
			}
			set {
				if ((value!=null)&&(value.Length!=1)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+1)+" was expected for variable \'vVector__209\'");
				}
				this.VVector__209 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__209_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__209") {
				return this.vVector__209;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__209") {
				this.vVector__209 = (Vector[])value;
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
			if (variableName=="vVector__209") {
				return this.VVector__209Marginal();
			}
			if (variableName=="vVector627") {
				return this.VVector627Marginal();
			}
			if (variableName=="vdouble__627") {
				return this.Vdouble__627Marginal();
			}
			if (variableName=="vdouble__628") {
				return this.Vdouble__628Marginal();
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
			this.Changed_vVector__209();
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

		/// <summary>Computations that depend on the observed value of vVector__209</summary>
		private void Changed_vVector__209()
		{
			if (this.Changed_vVector__209_iterationsDone==1) {
				return ;
			}
			this.vVector__209_marginal = new PointMass<Vector[]>(this.VVector__209);
			// The constant 'vVectorGaussian209'
			VectorGaussian vVectorGaussian209 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {1547829870.0, 525077980.0, 200270.0}), new PositiveDefiniteMatrix(new double[3, 3] {{4254590363351.0, 1127383488860.0, 433199230.0}, {1127383488860.0, 482723521821.0, 146764360.0}, {433199230.0, 146764360.0, 56221.0}}));
			this.vVector627_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian209);
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector627_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector627_rep' from Replicate factor
			vVector627_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian209);
			// Message to 'vVector627_marginal' from Variable factor
			this.vVector627_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector627_rep_B_toDef, vVectorGaussian209, this.vVector627_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__627_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__627' Forwards messages.
			vdouble__627_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index209 = 0; index209<1; index209++) {
				vdouble__627_F[index209] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__628_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__628' Forwards messages.
			vdouble__628_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index209 = 0; index209<1; index209++) {
				vdouble__628_F[index209] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector627_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			DistributionRefArray<VectorGaussian,Vector> vVector627_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector627_rep' Forwards messages.
			vVector627_rep_F = new DistributionRefArray<VectorGaussian,Vector>(1);
			// Create array for 'vVector627_rep' Backwards messages.
			vVector627_rep_B = new DistributionRefArray<VectorGaussian,Vector>(1);
			for(int index209 = 0; index209<1; index209++) {
				vVector627_rep_B[index209] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian209);
				vVector627_rep_F[index209] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian209);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector627_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector627_rep' from Replicate factor
			vVector627_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian209);
			// Message to 'vVector627_rep' from Replicate factor
			vVector627_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector627_rep_B_toDef, vVectorGaussian209, vVector627_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector627_rep_F_index209__AMean'
			Vector[] vVector627_rep_F_index209__AMean = new Vector[1];
			for(int index209 = 0; index209<1; index209++) {
				// Message to 'vdouble__628' from InnerProduct factor
				vVector627_rep_F_index209__AMean[index209] = InnerProductOp.AMeanInit(vVector627_rep_F[index209]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector627_rep_F_index209__AVariance'
			PositiveDefiniteMatrix[] vVector627_rep_F_index209__AVariance = new PositiveDefiniteMatrix[1];
			for(int index209 = 0; index209<1; index209++) {
				// Message to 'vdouble__628' from InnerProduct factor
				vVector627_rep_F_index209__AVariance[index209] = InnerProductOp.AVarianceInit(vVector627_rep_F[index209]);
				// Message to 'vVector627_rep' from Replicate factor
				vVector627_rep_F[index209] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector627_rep_B[index209], vVector627_rep_F_marginal, index209, vVector627_rep_F[index209]);
			}
			// Create array for 'vdouble__628_marginal' Forwards messages.
			this.vdouble__628_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index209 = 0; index209<1; index209++) {
				this.vdouble__628_marginal_F[index209] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__628'
			DistributionStructArray<Gaussian,double> vdouble__628_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__628_use' Backwards messages.
			vdouble__628_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index209 = 0; index209<1; index209++) {
				vdouble__628_use_B[index209] = Gaussian.Uniform();
				// Message to 'vdouble__628' from InnerProduct factor
				vVector627_rep_F_index209__AVariance[index209] = InnerProductOp.AVariance(vVector627_rep_F[index209], vVector627_rep_F_index209__AVariance[index209]);
				// Message to 'vdouble__628' from InnerProduct factor
				vVector627_rep_F_index209__AMean[index209] = InnerProductOp.AMean(vVector627_rep_F[index209], vVector627_rep_F_index209__AVariance[index209], vVector627_rep_F_index209__AMean[index209]);
				// Message to 'vdouble__628' from InnerProduct factor
				vdouble__628_F[index209] = InnerProductOp.InnerProductAverageConditional(vVector627_rep_F_index209__AMean[index209], vVector627_rep_F_index209__AVariance[index209], this.VVector__209[index209]);
				// Message to 'vdouble__628_marginal' from DerivedVariable factor
				this.vdouble__628_marginal_F[index209] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__628_use_B[index209], vdouble__628_F[index209], this.vdouble__628_marginal_F[index209]);
			}
			// Create array for 'vdouble__627_marginal' Forwards messages.
			this.vdouble__627_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index209 = 0; index209<1; index209++) {
				this.vdouble__627_marginal_F[index209] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__627'
			DistributionStructArray<Gaussian,double> vdouble__627_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__627_use' Backwards messages.
			vdouble__627_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index209 = 0; index209<1; index209++) {
				vdouble__627_use_B[index209] = Gaussian.Uniform();
				// Message to 'vdouble__627' from GaussianFromMeanAndVariance factor
				vdouble__627_F[index209] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__628_F[index209], 0.1);
				// Message to 'vdouble__627_marginal' from Variable factor
				this.vdouble__627_marginal_F[index209] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__627_use_B[index209], vdouble__627_F[index209], this.vdouble__627_marginal_F[index209]);
			}
			this.Changed_vVector__209_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__209' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__209Marginal()
		{
			return this.vVector__209_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector627' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector627Marginal()
		{
			return this.vVector627_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__627' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__627Marginal()
		{
			return this.vdouble__627_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__628' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__628Marginal()
		{
			return this.vdouble__628_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}