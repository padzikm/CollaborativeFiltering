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
	public partial class Model115_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__116 property</summary>
		private Vector[] VVector__116;
		/// <summary>Field backing the vdouble__348 property</summary>
		private double[] Vdouble__348;
		/// <summary>The number of iterations last computed by Changed_vVector__116_vdouble__348. Set this to zero to force re-execution of Changed_vVector__116_vdouble__348</summary>
		public int Changed_vVector__116_vdouble__348_iterationsDone;
		public PointMass<Vector[]> vVector__116_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__348_marginal;
		/// <summary>Message to marginal of 'vVector349'</summary>
		public VectorGaussian vVector349_marginal_F;
		/// <summary>Message to marginal of 'vdouble__349'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__349_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__116'</summary>
		public Vector[] vVector__116
		{
			get {
				return this.VVector__116;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__116\'");
				}
				this.VVector__116 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__116_vdouble__348_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__348'</summary>
		public double[] vdouble__348
		{
			get {
				return this.Vdouble__348;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__348\'");
				}
				this.Vdouble__348 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__116_vdouble__348_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__116") {
				return this.vVector__116;
			}
			if (variableName=="vdouble__348") {
				return this.vdouble__348;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__116") {
				this.vVector__116 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__348") {
				this.vdouble__348 = (double[])value;
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
			if (variableName=="vVector__116") {
				return this.VVector__116Marginal();
			}
			if (variableName=="vdouble__348") {
				return this.Vdouble__348Marginal();
			}
			if (variableName=="vVector349") {
				return this.VVector349Marginal();
			}
			if (variableName=="vdouble__349") {
				return this.Vdouble__349Marginal();
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
			this.Changed_vVector__116_vdouble__348();
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

		/// <summary>Computations that depend on the observed value of vVector__116 and vdouble__348</summary>
		private void Changed_vVector__116_vdouble__348()
		{
			if (this.Changed_vVector__116_vdouble__348_iterationsDone==1) {
				return ;
			}
			this.vVector__116_marginal = new PointMass<Vector[]>(this.VVector__116);
			this.vdouble__348_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index116) {
				return Gaussian.Uniform();
			});
			this.vdouble__348_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__348_marginal, this.Vdouble__348);
			// The constant 'vVectorGaussian116'
			VectorGaussian vVectorGaussian116 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector349_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian116);
			// Message from use of 'vdouble__349'
			DistributionStructArray<Gaussian,double> vdouble__349_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__349_use' Backwards messages.
			vdouble__349_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index116 = 0; index116<5622; index116++) {
				vdouble__349_use_B[index116] = Gaussian.Uniform();
				// Message to 'vdouble__349_use' from GaussianFromMeanAndVariance factor
				vdouble__349_use_B[index116] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__348[index116], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector349_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector349_rep' Backwards messages.
			vVector349_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index116 = 0; index116<5622; index116++) {
				vVector349_rep_B[index116] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian116);
				// Message to 'vVector349_rep' from InnerProduct factor
				vVector349_rep_B[index116] = InnerProductOp.AAverageConditional(vdouble__349_use_B[index116], this.VVector__116[index116], vVector349_rep_B[index116]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector349_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector349_rep' from Replicate factor
			vVector349_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian116);
			// Message to 'vVector349_rep' from Replicate factor
			vVector349_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector349_rep_B, vVector349_rep_B_toDef);
			// Message to 'vVector349_marginal' from Variable factor
			this.vVector349_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector349_rep_B_toDef, vVectorGaussian116, this.vVector349_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__349_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__349' Forwards messages.
			vdouble__349_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index116 = 0; index116<5622; index116++) {
				vdouble__349_F[index116] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector349_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector349_rep' Forwards messages.
			vVector349_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index116 = 0; index116<5622; index116++) {
				vVector349_rep_F[index116] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian116);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector349_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector349_rep' from Replicate factor
			vVector349_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian116);
			// Message to 'vVector349_rep' from Replicate factor
			vVector349_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector349_rep_B_toDef, vVectorGaussian116, vVector349_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector349_rep_F_index116__AMean'
			Vector[] vVector349_rep_F_index116__AMean = new Vector[5622];
			for(int index116 = 0; index116<5622; index116++) {
				// Message to 'vdouble__349' from InnerProduct factor
				vVector349_rep_F_index116__AMean[index116] = InnerProductOp.AMeanInit(vVector349_rep_F[index116]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector349_rep_F_index116__AVariance'
			PositiveDefiniteMatrix[] vVector349_rep_F_index116__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index116 = 0; index116<5622; index116++) {
				// Message to 'vdouble__349' from InnerProduct factor
				vVector349_rep_F_index116__AVariance[index116] = InnerProductOp.AVarianceInit(vVector349_rep_F[index116]);
				// Message to 'vVector349_rep' from Replicate factor
				vVector349_rep_F[index116] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector349_rep_B[index116], vVector349_rep_F_marginal, index116, vVector349_rep_F[index116]);
			}
			// Create array for 'vdouble__349_marginal' Forwards messages.
			this.vdouble__349_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index116 = 0; index116<5622; index116++) {
				this.vdouble__349_marginal_F[index116] = Gaussian.Uniform();
				// Message to 'vdouble__349' from InnerProduct factor
				vVector349_rep_F_index116__AVariance[index116] = InnerProductOp.AVariance(vVector349_rep_F[index116], vVector349_rep_F_index116__AVariance[index116]);
				// Message to 'vdouble__349' from InnerProduct factor
				vVector349_rep_F_index116__AMean[index116] = InnerProductOp.AMean(vVector349_rep_F[index116], vVector349_rep_F_index116__AVariance[index116], vVector349_rep_F_index116__AMean[index116]);
				// Message to 'vdouble__349' from InnerProduct factor
				vdouble__349_F[index116] = InnerProductOp.InnerProductAverageConditional(vVector349_rep_F_index116__AMean[index116], vVector349_rep_F_index116__AVariance[index116], this.VVector__116[index116]);
				// Message to 'vdouble__349_marginal' from DerivedVariable factor
				this.vdouble__349_marginal_F[index116] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__349_use_B[index116], vdouble__349_F[index116], this.vdouble__349_marginal_F[index116]);
			}
			this.Changed_vVector__116_vdouble__348_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__116' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__116Marginal()
		{
			return this.vVector__116_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__348' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__348Marginal()
		{
			return this.vdouble__348_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector349' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector349Marginal()
		{
			return this.vVector349_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__349' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__349Marginal()
		{
			return this.vdouble__349_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
