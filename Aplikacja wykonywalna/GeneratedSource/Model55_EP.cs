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
	public partial class Model55_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__56 property</summary>
		private Vector[] VVector__56;
		/// <summary>Field backing the vdouble__168 property</summary>
		private double[] Vdouble__168;
		/// <summary>The number of iterations last computed by Changed_vVector__56_vdouble__168. Set this to zero to force re-execution of Changed_vVector__56_vdouble__168</summary>
		public int Changed_vVector__56_vdouble__168_iterationsDone;
		public PointMass<Vector[]> vVector__56_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__168_marginal;
		/// <summary>Message to marginal of 'vVector169'</summary>
		public VectorGaussian vVector169_marginal_F;
		/// <summary>Message to marginal of 'vdouble__169'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__169_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__56'</summary>
		public Vector[] vVector__56
		{
			get {
				return this.VVector__56;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__56\'");
				}
				this.VVector__56 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__56_vdouble__168_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__168'</summary>
		public double[] vdouble__168
		{
			get {
				return this.Vdouble__168;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__168\'");
				}
				this.Vdouble__168 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__56_vdouble__168_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__56") {
				return this.vVector__56;
			}
			if (variableName=="vdouble__168") {
				return this.vdouble__168;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__56") {
				this.vVector__56 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__168") {
				this.vdouble__168 = (double[])value;
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
			if (variableName=="vVector__56") {
				return this.VVector__56Marginal();
			}
			if (variableName=="vdouble__168") {
				return this.Vdouble__168Marginal();
			}
			if (variableName=="vVector169") {
				return this.VVector169Marginal();
			}
			if (variableName=="vdouble__169") {
				return this.Vdouble__169Marginal();
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
			this.Changed_vVector__56_vdouble__168();
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

		/// <summary>Computations that depend on the observed value of vVector__56 and vdouble__168</summary>
		private void Changed_vVector__56_vdouble__168()
		{
			if (this.Changed_vVector__56_vdouble__168_iterationsDone==1) {
				return ;
			}
			this.vVector__56_marginal = new PointMass<Vector[]>(this.VVector__56);
			this.vdouble__168_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index56) {
				return Gaussian.Uniform();
			});
			this.vdouble__168_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__168_marginal, this.Vdouble__168);
			// The constant 'vVectorGaussian56'
			VectorGaussian vVectorGaussian56 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector169_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian56);
			// Message from use of 'vdouble__169'
			DistributionStructArray<Gaussian,double> vdouble__169_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__169_use' Backwards messages.
			vdouble__169_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index56 = 0; index56<5622; index56++) {
				vdouble__169_use_B[index56] = Gaussian.Uniform();
				// Message to 'vdouble__169_use' from GaussianFromMeanAndVariance factor
				vdouble__169_use_B[index56] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__168[index56], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector169_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector169_rep' Backwards messages.
			vVector169_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index56 = 0; index56<5622; index56++) {
				vVector169_rep_B[index56] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian56);
				// Message to 'vVector169_rep' from InnerProduct factor
				vVector169_rep_B[index56] = InnerProductOp.AAverageConditional(vdouble__169_use_B[index56], this.VVector__56[index56], vVector169_rep_B[index56]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector169_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector169_rep' from Replicate factor
			vVector169_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian56);
			// Message to 'vVector169_rep' from Replicate factor
			vVector169_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector169_rep_B, vVector169_rep_B_toDef);
			// Message to 'vVector169_marginal' from Variable factor
			this.vVector169_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector169_rep_B_toDef, vVectorGaussian56, this.vVector169_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__169_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__169' Forwards messages.
			vdouble__169_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index56 = 0; index56<5622; index56++) {
				vdouble__169_F[index56] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector169_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector169_rep' Forwards messages.
			vVector169_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index56 = 0; index56<5622; index56++) {
				vVector169_rep_F[index56] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian56);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector169_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector169_rep' from Replicate factor
			vVector169_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian56);
			// Message to 'vVector169_rep' from Replicate factor
			vVector169_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector169_rep_B_toDef, vVectorGaussian56, vVector169_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector169_rep_F_index56__AMean'
			Vector[] vVector169_rep_F_index56__AMean = new Vector[5622];
			for(int index56 = 0; index56<5622; index56++) {
				// Message to 'vdouble__169' from InnerProduct factor
				vVector169_rep_F_index56__AMean[index56] = InnerProductOp.AMeanInit(vVector169_rep_F[index56]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector169_rep_F_index56__AVariance'
			PositiveDefiniteMatrix[] vVector169_rep_F_index56__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index56 = 0; index56<5622; index56++) {
				// Message to 'vdouble__169' from InnerProduct factor
				vVector169_rep_F_index56__AVariance[index56] = InnerProductOp.AVarianceInit(vVector169_rep_F[index56]);
				// Message to 'vVector169_rep' from Replicate factor
				vVector169_rep_F[index56] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector169_rep_B[index56], vVector169_rep_F_marginal, index56, vVector169_rep_F[index56]);
			}
			// Create array for 'vdouble__169_marginal' Forwards messages.
			this.vdouble__169_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index56 = 0; index56<5622; index56++) {
				this.vdouble__169_marginal_F[index56] = Gaussian.Uniform();
				// Message to 'vdouble__169' from InnerProduct factor
				vVector169_rep_F_index56__AVariance[index56] = InnerProductOp.AVariance(vVector169_rep_F[index56], vVector169_rep_F_index56__AVariance[index56]);
				// Message to 'vdouble__169' from InnerProduct factor
				vVector169_rep_F_index56__AMean[index56] = InnerProductOp.AMean(vVector169_rep_F[index56], vVector169_rep_F_index56__AVariance[index56], vVector169_rep_F_index56__AMean[index56]);
				// Message to 'vdouble__169' from InnerProduct factor
				vdouble__169_F[index56] = InnerProductOp.InnerProductAverageConditional(vVector169_rep_F_index56__AMean[index56], vVector169_rep_F_index56__AVariance[index56], this.VVector__56[index56]);
				// Message to 'vdouble__169_marginal' from DerivedVariable factor
				this.vdouble__169_marginal_F[index56] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__169_use_B[index56], vdouble__169_F[index56], this.vdouble__169_marginal_F[index56]);
			}
			this.Changed_vVector__56_vdouble__168_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__56' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__56Marginal()
		{
			return this.vVector__56_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__168' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__168Marginal()
		{
			return this.vdouble__168_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector169' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector169Marginal()
		{
			return this.vVector169_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__169' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__169Marginal()
		{
			return this.vdouble__169_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}