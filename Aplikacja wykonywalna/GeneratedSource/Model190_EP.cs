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
	public partial class Model190_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__191 property</summary>
		private Vector[] VVector__191;
		/// <summary>The number of iterations last computed by Changed_vVector__191. Set this to zero to force re-execution of Changed_vVector__191</summary>
		public int Changed_vVector__191_iterationsDone;
		public PointMass<Vector[]> vVector__191_marginal;
		/// <summary>Message to marginal of 'vVector573'</summary>
		public VectorGaussian vVector573_marginal_F;
		/// <summary>Message to marginal of 'vdouble__574'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__574_marginal_F;
		/// <summary>Message to marginal of 'vdouble__573'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__573_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__191'</summary>
		public Vector[] vVector__191
		{
			get {
				return this.VVector__191;
			}
			set {
				if ((value!=null)&&(value.Length!=1)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+1)+" was expected for variable \'vVector__191\'");
				}
				this.VVector__191 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__191_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__191") {
				return this.vVector__191;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__191") {
				this.vVector__191 = (Vector[])value;
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
			if (variableName=="vVector__191") {
				return this.VVector__191Marginal();
			}
			if (variableName=="vVector573") {
				return this.VVector573Marginal();
			}
			if (variableName=="vdouble__573") {
				return this.Vdouble__573Marginal();
			}
			if (variableName=="vdouble__574") {
				return this.Vdouble__574Marginal();
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
			this.Changed_vVector__191();
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

		/// <summary>Computations that depend on the observed value of vVector__191</summary>
		private void Changed_vVector__191()
		{
			if (this.Changed_vVector__191_iterationsDone==1) {
				return ;
			}
			this.vVector__191_marginal = new PointMass<Vector[]>(this.VVector__191);
			// The constant 'vVectorGaussian191'
			VectorGaussian vVectorGaussian191 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {1547829870.0, 525077980.0, 200270.0}), new PositiveDefiniteMatrix(new double[3, 3] {{4254590363351.0, 1127383488860.0, 433199230.0}, {1127383488860.0, 482723521821.0, 146764360.0}, {433199230.0, 146764360.0, 56221.0}}));
			this.vVector573_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian191);
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector573_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector573_rep' from Replicate factor
			vVector573_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian191);
			// Message to 'vVector573_marginal' from Variable factor
			this.vVector573_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector573_rep_B_toDef, vVectorGaussian191, this.vVector573_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__573_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__573' Forwards messages.
			vdouble__573_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index191 = 0; index191<1; index191++) {
				vdouble__573_F[index191] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__574_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__574' Forwards messages.
			vdouble__574_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index191 = 0; index191<1; index191++) {
				vdouble__574_F[index191] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector573_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			DistributionRefArray<VectorGaussian,Vector> vVector573_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector573_rep' Forwards messages.
			vVector573_rep_F = new DistributionRefArray<VectorGaussian,Vector>(1);
			// Create array for 'vVector573_rep' Backwards messages.
			vVector573_rep_B = new DistributionRefArray<VectorGaussian,Vector>(1);
			for(int index191 = 0; index191<1; index191++) {
				vVector573_rep_B[index191] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian191);
				vVector573_rep_F[index191] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian191);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector573_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector573_rep' from Replicate factor
			vVector573_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian191);
			// Message to 'vVector573_rep' from Replicate factor
			vVector573_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector573_rep_B_toDef, vVectorGaussian191, vVector573_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector573_rep_F_index191__AMean'
			Vector[] vVector573_rep_F_index191__AMean = new Vector[1];
			for(int index191 = 0; index191<1; index191++) {
				// Message to 'vdouble__574' from InnerProduct factor
				vVector573_rep_F_index191__AMean[index191] = InnerProductOp.AMeanInit(vVector573_rep_F[index191]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector573_rep_F_index191__AVariance'
			PositiveDefiniteMatrix[] vVector573_rep_F_index191__AVariance = new PositiveDefiniteMatrix[1];
			for(int index191 = 0; index191<1; index191++) {
				// Message to 'vdouble__574' from InnerProduct factor
				vVector573_rep_F_index191__AVariance[index191] = InnerProductOp.AVarianceInit(vVector573_rep_F[index191]);
				// Message to 'vVector573_rep' from Replicate factor
				vVector573_rep_F[index191] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector573_rep_B[index191], vVector573_rep_F_marginal, index191, vVector573_rep_F[index191]);
			}
			// Create array for 'vdouble__574_marginal' Forwards messages.
			this.vdouble__574_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index191 = 0; index191<1; index191++) {
				this.vdouble__574_marginal_F[index191] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__574'
			DistributionStructArray<Gaussian,double> vdouble__574_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__574_use' Backwards messages.
			vdouble__574_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index191 = 0; index191<1; index191++) {
				vdouble__574_use_B[index191] = Gaussian.Uniform();
				// Message to 'vdouble__574' from InnerProduct factor
				vVector573_rep_F_index191__AVariance[index191] = InnerProductOp.AVariance(vVector573_rep_F[index191], vVector573_rep_F_index191__AVariance[index191]);
				// Message to 'vdouble__574' from InnerProduct factor
				vVector573_rep_F_index191__AMean[index191] = InnerProductOp.AMean(vVector573_rep_F[index191], vVector573_rep_F_index191__AVariance[index191], vVector573_rep_F_index191__AMean[index191]);
				// Message to 'vdouble__574' from InnerProduct factor
				vdouble__574_F[index191] = InnerProductOp.InnerProductAverageConditional(vVector573_rep_F_index191__AMean[index191], vVector573_rep_F_index191__AVariance[index191], this.VVector__191[index191]);
				// Message to 'vdouble__574_marginal' from DerivedVariable factor
				this.vdouble__574_marginal_F[index191] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__574_use_B[index191], vdouble__574_F[index191], this.vdouble__574_marginal_F[index191]);
			}
			// Create array for 'vdouble__573_marginal' Forwards messages.
			this.vdouble__573_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index191 = 0; index191<1; index191++) {
				this.vdouble__573_marginal_F[index191] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__573'
			DistributionStructArray<Gaussian,double> vdouble__573_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__573_use' Backwards messages.
			vdouble__573_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index191 = 0; index191<1; index191++) {
				vdouble__573_use_B[index191] = Gaussian.Uniform();
				// Message to 'vdouble__573' from GaussianFromMeanAndVariance factor
				vdouble__573_F[index191] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__574_F[index191], 0.1);
				// Message to 'vdouble__573_marginal' from Variable factor
				this.vdouble__573_marginal_F[index191] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__573_use_B[index191], vdouble__573_F[index191], this.vdouble__573_marginal_F[index191]);
			}
			this.Changed_vVector__191_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__191' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__191Marginal()
		{
			return this.vVector__191_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector573' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector573Marginal()
		{
			return this.vVector573_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__573' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__573Marginal()
		{
			return this.vdouble__573_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__574' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__574Marginal()
		{
			return this.vdouble__574_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
