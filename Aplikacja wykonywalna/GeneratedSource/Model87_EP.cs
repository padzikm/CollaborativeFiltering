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
	public partial class Model87_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__88 property</summary>
		private Vector[] VVector__88;
		/// <summary>Field backing the vdouble__264 property</summary>
		private double[] Vdouble__264;
		/// <summary>The number of iterations last computed by Changed_vVector__88_vdouble__264. Set this to zero to force re-execution of Changed_vVector__88_vdouble__264</summary>
		public int Changed_vVector__88_vdouble__264_iterationsDone;
		public PointMass<Vector[]> vVector__88_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__264_marginal;
		/// <summary>Message to marginal of 'vVector265'</summary>
		public VectorGaussian vVector265_marginal_F;
		/// <summary>Message to marginal of 'vdouble__265'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__265_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__88'</summary>
		public Vector[] vVector__88
		{
			get {
				return this.VVector__88;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__88\'");
				}
				this.VVector__88 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__88_vdouble__264_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__264'</summary>
		public double[] vdouble__264
		{
			get {
				return this.Vdouble__264;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__264\'");
				}
				this.Vdouble__264 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__88_vdouble__264_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__88") {
				return this.vVector__88;
			}
			if (variableName=="vdouble__264") {
				return this.vdouble__264;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__88") {
				this.vVector__88 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__264") {
				this.vdouble__264 = (double[])value;
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
			if (variableName=="vVector__88") {
				return this.VVector__88Marginal();
			}
			if (variableName=="vdouble__264") {
				return this.Vdouble__264Marginal();
			}
			if (variableName=="vVector265") {
				return this.VVector265Marginal();
			}
			if (variableName=="vdouble__265") {
				return this.Vdouble__265Marginal();
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
			this.Changed_vVector__88_vdouble__264();
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

		/// <summary>Computations that depend on the observed value of vVector__88 and vdouble__264</summary>
		private void Changed_vVector__88_vdouble__264()
		{
			if (this.Changed_vVector__88_vdouble__264_iterationsDone==1) {
				return ;
			}
			this.vVector__88_marginal = new PointMass<Vector[]>(this.VVector__88);
			this.vdouble__264_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index88) {
				return Gaussian.Uniform();
			});
			this.vdouble__264_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__264_marginal, this.Vdouble__264);
			// The constant 'vVectorGaussian88'
			VectorGaussian vVectorGaussian88 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector265_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian88);
			// Message from use of 'vdouble__265'
			DistributionStructArray<Gaussian,double> vdouble__265_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__265_use' Backwards messages.
			vdouble__265_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index88 = 0; index88<5622; index88++) {
				vdouble__265_use_B[index88] = Gaussian.Uniform();
				// Message to 'vdouble__265_use' from GaussianFromMeanAndVariance factor
				vdouble__265_use_B[index88] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__264[index88], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector265_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector265_rep' Backwards messages.
			vVector265_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index88 = 0; index88<5622; index88++) {
				vVector265_rep_B[index88] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian88);
				// Message to 'vVector265_rep' from InnerProduct factor
				vVector265_rep_B[index88] = InnerProductOp.AAverageConditional(vdouble__265_use_B[index88], this.VVector__88[index88], vVector265_rep_B[index88]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector265_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector265_rep' from Replicate factor
			vVector265_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian88);
			// Message to 'vVector265_rep' from Replicate factor
			vVector265_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector265_rep_B, vVector265_rep_B_toDef);
			// Message to 'vVector265_marginal' from Variable factor
			this.vVector265_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector265_rep_B_toDef, vVectorGaussian88, this.vVector265_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__265_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__265' Forwards messages.
			vdouble__265_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index88 = 0; index88<5622; index88++) {
				vdouble__265_F[index88] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector265_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector265_rep' Forwards messages.
			vVector265_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index88 = 0; index88<5622; index88++) {
				vVector265_rep_F[index88] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian88);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector265_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector265_rep' from Replicate factor
			vVector265_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian88);
			// Message to 'vVector265_rep' from Replicate factor
			vVector265_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector265_rep_B_toDef, vVectorGaussian88, vVector265_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector265_rep_F_index88__AMean'
			Vector[] vVector265_rep_F_index88__AMean = new Vector[5622];
			for(int index88 = 0; index88<5622; index88++) {
				// Message to 'vdouble__265' from InnerProduct factor
				vVector265_rep_F_index88__AMean[index88] = InnerProductOp.AMeanInit(vVector265_rep_F[index88]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector265_rep_F_index88__AVariance'
			PositiveDefiniteMatrix[] vVector265_rep_F_index88__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index88 = 0; index88<5622; index88++) {
				// Message to 'vdouble__265' from InnerProduct factor
				vVector265_rep_F_index88__AVariance[index88] = InnerProductOp.AVarianceInit(vVector265_rep_F[index88]);
				// Message to 'vVector265_rep' from Replicate factor
				vVector265_rep_F[index88] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector265_rep_B[index88], vVector265_rep_F_marginal, index88, vVector265_rep_F[index88]);
			}
			// Create array for 'vdouble__265_marginal' Forwards messages.
			this.vdouble__265_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index88 = 0; index88<5622; index88++) {
				this.vdouble__265_marginal_F[index88] = Gaussian.Uniform();
				// Message to 'vdouble__265' from InnerProduct factor
				vVector265_rep_F_index88__AVariance[index88] = InnerProductOp.AVariance(vVector265_rep_F[index88], vVector265_rep_F_index88__AVariance[index88]);
				// Message to 'vdouble__265' from InnerProduct factor
				vVector265_rep_F_index88__AMean[index88] = InnerProductOp.AMean(vVector265_rep_F[index88], vVector265_rep_F_index88__AVariance[index88], vVector265_rep_F_index88__AMean[index88]);
				// Message to 'vdouble__265' from InnerProduct factor
				vdouble__265_F[index88] = InnerProductOp.InnerProductAverageConditional(vVector265_rep_F_index88__AMean[index88], vVector265_rep_F_index88__AVariance[index88], this.VVector__88[index88]);
				// Message to 'vdouble__265_marginal' from DerivedVariable factor
				this.vdouble__265_marginal_F[index88] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__265_use_B[index88], vdouble__265_F[index88], this.vdouble__265_marginal_F[index88]);
			}
			this.Changed_vVector__88_vdouble__264_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__88' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__88Marginal()
		{
			return this.vVector__88_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__264' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__264Marginal()
		{
			return this.vdouble__264_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector265' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector265Marginal()
		{
			return this.vVector265_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__265' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__265Marginal()
		{
			return this.vdouble__265_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
