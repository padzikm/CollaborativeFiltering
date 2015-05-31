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
	public partial class Model141_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__142 property</summary>
		private Vector[] VVector__142;
		/// <summary>Field backing the vdouble__426 property</summary>
		private double[] Vdouble__426;
		/// <summary>The number of iterations last computed by Changed_vVector__142_vdouble__426. Set this to zero to force re-execution of Changed_vVector__142_vdouble__426</summary>
		public int Changed_vVector__142_vdouble__426_iterationsDone;
		public PointMass<Vector[]> vVector__142_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__426_marginal;
		/// <summary>Message to marginal of 'vVector427'</summary>
		public VectorGaussian vVector427_marginal_F;
		/// <summary>Message to marginal of 'vdouble__427'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__427_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__142'</summary>
		public Vector[] vVector__142
		{
			get {
				return this.VVector__142;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__142\'");
				}
				this.VVector__142 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__142_vdouble__426_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__426'</summary>
		public double[] vdouble__426
		{
			get {
				return this.Vdouble__426;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__426\'");
				}
				this.Vdouble__426 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__142_vdouble__426_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__142") {
				return this.vVector__142;
			}
			if (variableName=="vdouble__426") {
				return this.vdouble__426;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__142") {
				this.vVector__142 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__426") {
				this.vdouble__426 = (double[])value;
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
			if (variableName=="vVector__142") {
				return this.VVector__142Marginal();
			}
			if (variableName=="vdouble__426") {
				return this.Vdouble__426Marginal();
			}
			if (variableName=="vVector427") {
				return this.VVector427Marginal();
			}
			if (variableName=="vdouble__427") {
				return this.Vdouble__427Marginal();
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
			this.Changed_vVector__142_vdouble__426();
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

		/// <summary>Computations that depend on the observed value of vVector__142 and vdouble__426</summary>
		private void Changed_vVector__142_vdouble__426()
		{
			if (this.Changed_vVector__142_vdouble__426_iterationsDone==1) {
				return ;
			}
			this.vVector__142_marginal = new PointMass<Vector[]>(this.VVector__142);
			this.vdouble__426_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index142) {
				return Gaussian.Uniform();
			});
			this.vdouble__426_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__426_marginal, this.Vdouble__426);
			// The constant 'vVectorGaussian142'
			VectorGaussian vVectorGaussian142 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector427_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian142);
			// Message from use of 'vdouble__427'
			DistributionStructArray<Gaussian,double> vdouble__427_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__427_use' Backwards messages.
			vdouble__427_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index142 = 0; index142<5622; index142++) {
				vdouble__427_use_B[index142] = Gaussian.Uniform();
				// Message to 'vdouble__427_use' from GaussianFromMeanAndVariance factor
				vdouble__427_use_B[index142] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__426[index142], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector427_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector427_rep' Backwards messages.
			vVector427_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index142 = 0; index142<5622; index142++) {
				vVector427_rep_B[index142] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian142);
				// Message to 'vVector427_rep' from InnerProduct factor
				vVector427_rep_B[index142] = InnerProductOp.AAverageConditional(vdouble__427_use_B[index142], this.VVector__142[index142], vVector427_rep_B[index142]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector427_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector427_rep' from Replicate factor
			vVector427_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian142);
			// Message to 'vVector427_rep' from Replicate factor
			vVector427_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector427_rep_B, vVector427_rep_B_toDef);
			// Message to 'vVector427_marginal' from Variable factor
			this.vVector427_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector427_rep_B_toDef, vVectorGaussian142, this.vVector427_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__427_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__427' Forwards messages.
			vdouble__427_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index142 = 0; index142<5622; index142++) {
				vdouble__427_F[index142] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector427_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector427_rep' Forwards messages.
			vVector427_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index142 = 0; index142<5622; index142++) {
				vVector427_rep_F[index142] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian142);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector427_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector427_rep' from Replicate factor
			vVector427_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian142);
			// Message to 'vVector427_rep' from Replicate factor
			vVector427_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector427_rep_B_toDef, vVectorGaussian142, vVector427_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector427_rep_F_index142__AMean'
			Vector[] vVector427_rep_F_index142__AMean = new Vector[5622];
			for(int index142 = 0; index142<5622; index142++) {
				// Message to 'vdouble__427' from InnerProduct factor
				vVector427_rep_F_index142__AMean[index142] = InnerProductOp.AMeanInit(vVector427_rep_F[index142]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector427_rep_F_index142__AVariance'
			PositiveDefiniteMatrix[] vVector427_rep_F_index142__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index142 = 0; index142<5622; index142++) {
				// Message to 'vdouble__427' from InnerProduct factor
				vVector427_rep_F_index142__AVariance[index142] = InnerProductOp.AVarianceInit(vVector427_rep_F[index142]);
				// Message to 'vVector427_rep' from Replicate factor
				vVector427_rep_F[index142] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector427_rep_B[index142], vVector427_rep_F_marginal, index142, vVector427_rep_F[index142]);
			}
			// Create array for 'vdouble__427_marginal' Forwards messages.
			this.vdouble__427_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index142 = 0; index142<5622; index142++) {
				this.vdouble__427_marginal_F[index142] = Gaussian.Uniform();
				// Message to 'vdouble__427' from InnerProduct factor
				vVector427_rep_F_index142__AVariance[index142] = InnerProductOp.AVariance(vVector427_rep_F[index142], vVector427_rep_F_index142__AVariance[index142]);
				// Message to 'vdouble__427' from InnerProduct factor
				vVector427_rep_F_index142__AMean[index142] = InnerProductOp.AMean(vVector427_rep_F[index142], vVector427_rep_F_index142__AVariance[index142], vVector427_rep_F_index142__AMean[index142]);
				// Message to 'vdouble__427' from InnerProduct factor
				vdouble__427_F[index142] = InnerProductOp.InnerProductAverageConditional(vVector427_rep_F_index142__AMean[index142], vVector427_rep_F_index142__AVariance[index142], this.VVector__142[index142]);
				// Message to 'vdouble__427_marginal' from DerivedVariable factor
				this.vdouble__427_marginal_F[index142] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__427_use_B[index142], vdouble__427_F[index142], this.vdouble__427_marginal_F[index142]);
			}
			this.Changed_vVector__142_vdouble__426_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__142' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__142Marginal()
		{
			return this.vVector__142_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__426' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__426Marginal()
		{
			return this.vdouble__426_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector427' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector427Marginal()
		{
			return this.vVector427_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__427' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__427Marginal()
		{
			return this.vdouble__427_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}