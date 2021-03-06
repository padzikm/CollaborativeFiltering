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
	public partial class Model33_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__34 property</summary>
		private Vector[] VVector__34;
		/// <summary>Field backing the vdouble__102 property</summary>
		private double[] Vdouble__102;
		/// <summary>The number of iterations last computed by Changed_vVector__34_vdouble__102. Set this to zero to force re-execution of Changed_vVector__34_vdouble__102</summary>
		public int Changed_vVector__34_vdouble__102_iterationsDone;
		public PointMass<Vector[]> vVector__34_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__102_marginal;
		/// <summary>Message to marginal of 'vVector103'</summary>
		public VectorGaussian vVector103_marginal_F;
		/// <summary>Message to marginal of 'vdouble__103'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__103_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__34'</summary>
		public Vector[] vVector__34
		{
			get {
				return this.VVector__34;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__34\'");
				}
				this.VVector__34 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__34_vdouble__102_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__102'</summary>
		public double[] vdouble__102
		{
			get {
				return this.Vdouble__102;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__102\'");
				}
				this.Vdouble__102 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__34_vdouble__102_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__34") {
				return this.vVector__34;
			}
			if (variableName=="vdouble__102") {
				return this.vdouble__102;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__34") {
				this.vVector__34 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__102") {
				this.vdouble__102 = (double[])value;
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
			if (variableName=="vVector__34") {
				return this.VVector__34Marginal();
			}
			if (variableName=="vdouble__102") {
				return this.Vdouble__102Marginal();
			}
			if (variableName=="vVector103") {
				return this.VVector103Marginal();
			}
			if (variableName=="vdouble__103") {
				return this.Vdouble__103Marginal();
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
			this.Changed_vVector__34_vdouble__102();
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

		/// <summary>Computations that depend on the observed value of vVector__34 and vdouble__102</summary>
		private void Changed_vVector__34_vdouble__102()
		{
			if (this.Changed_vVector__34_vdouble__102_iterationsDone==1) {
				return ;
			}
			this.vVector__34_marginal = new PointMass<Vector[]>(this.VVector__34);
			this.vdouble__102_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index34) {
				return Gaussian.Uniform();
			});
			this.vdouble__102_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__102_marginal, this.Vdouble__102);
			// The constant 'vVectorGaussian34'
			VectorGaussian vVectorGaussian34 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector103_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian34);
			// Message from use of 'vdouble__103'
			DistributionStructArray<Gaussian,double> vdouble__103_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__103_use' Backwards messages.
			vdouble__103_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index34 = 0; index34<5622; index34++) {
				vdouble__103_use_B[index34] = Gaussian.Uniform();
				// Message to 'vdouble__103_use' from GaussianFromMeanAndVariance factor
				vdouble__103_use_B[index34] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__102[index34], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector103_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector103_rep' Backwards messages.
			vVector103_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index34 = 0; index34<5622; index34++) {
				vVector103_rep_B[index34] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian34);
				// Message to 'vVector103_rep' from InnerProduct factor
				vVector103_rep_B[index34] = InnerProductOp.AAverageConditional(vdouble__103_use_B[index34], this.VVector__34[index34], vVector103_rep_B[index34]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector103_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector103_rep' from Replicate factor
			vVector103_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian34);
			// Message to 'vVector103_rep' from Replicate factor
			vVector103_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector103_rep_B, vVector103_rep_B_toDef);
			// Message to 'vVector103_marginal' from Variable factor
			this.vVector103_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector103_rep_B_toDef, vVectorGaussian34, this.vVector103_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__103_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__103' Forwards messages.
			vdouble__103_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index34 = 0; index34<5622; index34++) {
				vdouble__103_F[index34] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector103_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector103_rep' Forwards messages.
			vVector103_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index34 = 0; index34<5622; index34++) {
				vVector103_rep_F[index34] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian34);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector103_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector103_rep' from Replicate factor
			vVector103_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian34);
			// Message to 'vVector103_rep' from Replicate factor
			vVector103_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector103_rep_B_toDef, vVectorGaussian34, vVector103_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector103_rep_F_index34__AMean'
			Vector[] vVector103_rep_F_index34__AMean = new Vector[5622];
			for(int index34 = 0; index34<5622; index34++) {
				// Message to 'vdouble__103' from InnerProduct factor
				vVector103_rep_F_index34__AMean[index34] = InnerProductOp.AMeanInit(vVector103_rep_F[index34]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector103_rep_F_index34__AVariance'
			PositiveDefiniteMatrix[] vVector103_rep_F_index34__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index34 = 0; index34<5622; index34++) {
				// Message to 'vdouble__103' from InnerProduct factor
				vVector103_rep_F_index34__AVariance[index34] = InnerProductOp.AVarianceInit(vVector103_rep_F[index34]);
				// Message to 'vVector103_rep' from Replicate factor
				vVector103_rep_F[index34] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector103_rep_B[index34], vVector103_rep_F_marginal, index34, vVector103_rep_F[index34]);
			}
			// Create array for 'vdouble__103_marginal' Forwards messages.
			this.vdouble__103_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index34 = 0; index34<5622; index34++) {
				this.vdouble__103_marginal_F[index34] = Gaussian.Uniform();
				// Message to 'vdouble__103' from InnerProduct factor
				vVector103_rep_F_index34__AVariance[index34] = InnerProductOp.AVariance(vVector103_rep_F[index34], vVector103_rep_F_index34__AVariance[index34]);
				// Message to 'vdouble__103' from InnerProduct factor
				vVector103_rep_F_index34__AMean[index34] = InnerProductOp.AMean(vVector103_rep_F[index34], vVector103_rep_F_index34__AVariance[index34], vVector103_rep_F_index34__AMean[index34]);
				// Message to 'vdouble__103' from InnerProduct factor
				vdouble__103_F[index34] = InnerProductOp.InnerProductAverageConditional(vVector103_rep_F_index34__AMean[index34], vVector103_rep_F_index34__AVariance[index34], this.VVector__34[index34]);
				// Message to 'vdouble__103_marginal' from DerivedVariable factor
				this.vdouble__103_marginal_F[index34] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__103_use_B[index34], vdouble__103_F[index34], this.vdouble__103_marginal_F[index34]);
			}
			this.Changed_vVector__34_vdouble__102_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__34' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__34Marginal()
		{
			return this.vVector__34_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__102' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__102Marginal()
		{
			return this.vdouble__102_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector103' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector103Marginal()
		{
			return this.vVector103_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__103' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__103Marginal()
		{
			return this.vdouble__103_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
