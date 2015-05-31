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
	public partial class Model236_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__237 property</summary>
		private Vector[] VVector__237;
		/// <summary>The number of iterations last computed by Changed_vVector__237. Set this to zero to force re-execution of Changed_vVector__237</summary>
		public int Changed_vVector__237_iterationsDone;
		public PointMass<Vector[]> vVector__237_marginal;
		/// <summary>Message to marginal of 'vVector711'</summary>
		public VectorGaussian vVector711_marginal_F;
		/// <summary>Message to marginal of 'vdouble__712'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__712_marginal_F;
		/// <summary>Message to marginal of 'vdouble__711'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__711_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__237'</summary>
		public Vector[] vVector__237
		{
			get {
				return this.VVector__237;
			}
			set {
				if ((value!=null)&&(value.Length!=1)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+1)+" was expected for variable \'vVector__237\'");
				}
				this.VVector__237 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__237_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__237") {
				return this.vVector__237;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__237") {
				this.vVector__237 = (Vector[])value;
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
			if (variableName=="vVector__237") {
				return this.VVector__237Marginal();
			}
			if (variableName=="vVector711") {
				return this.VVector711Marginal();
			}
			if (variableName=="vdouble__711") {
				return this.Vdouble__711Marginal();
			}
			if (variableName=="vdouble__712") {
				return this.Vdouble__712Marginal();
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
			this.Changed_vVector__237();
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

		/// <summary>Computations that depend on the observed value of vVector__237</summary>
		private void Changed_vVector__237()
		{
			if (this.Changed_vVector__237_iterationsDone==1) {
				return ;
			}
			this.vVector__237_marginal = new PointMass<Vector[]>(this.VVector__237);
			// The constant 'vVectorGaussian237'
			VectorGaussian vVectorGaussian237 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {1547829870.0, 525077980.0, 200270.0}), new PositiveDefiniteMatrix(new double[3, 3] {{4254590363351.0, 1127383488860.0, 433199230.0}, {1127383488860.0, 482723521821.0, 146764360.0}, {433199230.0, 146764360.0, 56221.0}}));
			this.vVector711_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian237);
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector711_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector711_rep' from Replicate factor
			vVector711_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian237);
			// Message to 'vVector711_marginal' from Variable factor
			this.vVector711_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector711_rep_B_toDef, vVectorGaussian237, this.vVector711_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__711_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__711' Forwards messages.
			vdouble__711_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index237 = 0; index237<1; index237++) {
				vdouble__711_F[index237] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__712_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__712' Forwards messages.
			vdouble__712_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index237 = 0; index237<1; index237++) {
				vdouble__712_F[index237] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector711_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			DistributionRefArray<VectorGaussian,Vector> vVector711_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector711_rep' Forwards messages.
			vVector711_rep_F = new DistributionRefArray<VectorGaussian,Vector>(1);
			// Create array for 'vVector711_rep' Backwards messages.
			vVector711_rep_B = new DistributionRefArray<VectorGaussian,Vector>(1);
			for(int index237 = 0; index237<1; index237++) {
				vVector711_rep_B[index237] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian237);
				vVector711_rep_F[index237] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian237);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector711_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector711_rep' from Replicate factor
			vVector711_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian237);
			// Message to 'vVector711_rep' from Replicate factor
			vVector711_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector711_rep_B_toDef, vVectorGaussian237, vVector711_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector711_rep_F_index237__AMean'
			Vector[] vVector711_rep_F_index237__AMean = new Vector[1];
			for(int index237 = 0; index237<1; index237++) {
				// Message to 'vdouble__712' from InnerProduct factor
				vVector711_rep_F_index237__AMean[index237] = InnerProductOp.AMeanInit(vVector711_rep_F[index237]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector711_rep_F_index237__AVariance'
			PositiveDefiniteMatrix[] vVector711_rep_F_index237__AVariance = new PositiveDefiniteMatrix[1];
			for(int index237 = 0; index237<1; index237++) {
				// Message to 'vdouble__712' from InnerProduct factor
				vVector711_rep_F_index237__AVariance[index237] = InnerProductOp.AVarianceInit(vVector711_rep_F[index237]);
				// Message to 'vVector711_rep' from Replicate factor
				vVector711_rep_F[index237] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector711_rep_B[index237], vVector711_rep_F_marginal, index237, vVector711_rep_F[index237]);
			}
			// Create array for 'vdouble__712_marginal' Forwards messages.
			this.vdouble__712_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index237 = 0; index237<1; index237++) {
				this.vdouble__712_marginal_F[index237] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__712'
			DistributionStructArray<Gaussian,double> vdouble__712_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__712_use' Backwards messages.
			vdouble__712_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index237 = 0; index237<1; index237++) {
				vdouble__712_use_B[index237] = Gaussian.Uniform();
				// Message to 'vdouble__712' from InnerProduct factor
				vVector711_rep_F_index237__AVariance[index237] = InnerProductOp.AVariance(vVector711_rep_F[index237], vVector711_rep_F_index237__AVariance[index237]);
				// Message to 'vdouble__712' from InnerProduct factor
				vVector711_rep_F_index237__AMean[index237] = InnerProductOp.AMean(vVector711_rep_F[index237], vVector711_rep_F_index237__AVariance[index237], vVector711_rep_F_index237__AMean[index237]);
				// Message to 'vdouble__712' from InnerProduct factor
				vdouble__712_F[index237] = InnerProductOp.InnerProductAverageConditional(vVector711_rep_F_index237__AMean[index237], vVector711_rep_F_index237__AVariance[index237], this.VVector__237[index237]);
				// Message to 'vdouble__712_marginal' from DerivedVariable factor
				this.vdouble__712_marginal_F[index237] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__712_use_B[index237], vdouble__712_F[index237], this.vdouble__712_marginal_F[index237]);
			}
			// Create array for 'vdouble__711_marginal' Forwards messages.
			this.vdouble__711_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index237 = 0; index237<1; index237++) {
				this.vdouble__711_marginal_F[index237] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__711'
			DistributionStructArray<Gaussian,double> vdouble__711_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__711_use' Backwards messages.
			vdouble__711_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index237 = 0; index237<1; index237++) {
				vdouble__711_use_B[index237] = Gaussian.Uniform();
				// Message to 'vdouble__711' from GaussianFromMeanAndVariance factor
				vdouble__711_F[index237] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__712_F[index237], 0.1);
				// Message to 'vdouble__711_marginal' from Variable factor
				this.vdouble__711_marginal_F[index237] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__711_use_B[index237], vdouble__711_F[index237], this.vdouble__711_marginal_F[index237]);
			}
			this.Changed_vVector__237_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__237' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__237Marginal()
		{
			return this.vVector__237_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector711' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector711Marginal()
		{
			return this.vVector711_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__711' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__711Marginal()
		{
			return this.vdouble__711_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__712' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__712Marginal()
		{
			return this.vdouble__712_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}