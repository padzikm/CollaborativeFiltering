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
	public partial class Model229_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__230 property</summary>
		private Vector[] VVector__230;
		/// <summary>Field backing the vdouble__690 property</summary>
		private double[] Vdouble__690;
		/// <summary>The number of iterations last computed by Changed_vVector__230_vdouble__690. Set this to zero to force re-execution of Changed_vVector__230_vdouble__690</summary>
		public int Changed_vVector__230_vdouble__690_iterationsDone;
		public PointMass<Vector[]> vVector__230_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__690_marginal;
		/// <summary>Message to marginal of 'vVector691'</summary>
		public VectorGaussian vVector691_marginal_F;
		/// <summary>Message to marginal of 'vdouble__691'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__691_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__230'</summary>
		public Vector[] vVector__230
		{
			get {
				return this.VVector__230;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__230\'");
				}
				this.VVector__230 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__230_vdouble__690_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__690'</summary>
		public double[] vdouble__690
		{
			get {
				return this.Vdouble__690;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__690\'");
				}
				this.Vdouble__690 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__230_vdouble__690_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__230") {
				return this.vVector__230;
			}
			if (variableName=="vdouble__690") {
				return this.vdouble__690;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__230") {
				this.vVector__230 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__690") {
				this.vdouble__690 = (double[])value;
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
			if (variableName=="vVector__230") {
				return this.VVector__230Marginal();
			}
			if (variableName=="vdouble__690") {
				return this.Vdouble__690Marginal();
			}
			if (variableName=="vVector691") {
				return this.VVector691Marginal();
			}
			if (variableName=="vdouble__691") {
				return this.Vdouble__691Marginal();
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
			this.Changed_vVector__230_vdouble__690();
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

		/// <summary>Computations that depend on the observed value of vVector__230 and vdouble__690</summary>
		private void Changed_vVector__230_vdouble__690()
		{
			if (this.Changed_vVector__230_vdouble__690_iterationsDone==1) {
				return ;
			}
			this.vVector__230_marginal = new PointMass<Vector[]>(this.VVector__230);
			this.vdouble__690_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index230) {
				return Gaussian.Uniform();
			});
			this.vdouble__690_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__690_marginal, this.Vdouble__690);
			// The constant 'vVectorGaussian230'
			VectorGaussian vVectorGaussian230 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector691_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian230);
			// Message from use of 'vdouble__691'
			DistributionStructArray<Gaussian,double> vdouble__691_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__691_use' Backwards messages.
			vdouble__691_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index230 = 0; index230<5622; index230++) {
				vdouble__691_use_B[index230] = Gaussian.Uniform();
				// Message to 'vdouble__691_use' from GaussianFromMeanAndVariance factor
				vdouble__691_use_B[index230] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__690[index230], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector691_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector691_rep' Backwards messages.
			vVector691_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index230 = 0; index230<5622; index230++) {
				vVector691_rep_B[index230] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian230);
				// Message to 'vVector691_rep' from InnerProduct factor
				vVector691_rep_B[index230] = InnerProductOp.AAverageConditional(vdouble__691_use_B[index230], this.VVector__230[index230], vVector691_rep_B[index230]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector691_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector691_rep' from Replicate factor
			vVector691_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian230);
			// Message to 'vVector691_rep' from Replicate factor
			vVector691_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector691_rep_B, vVector691_rep_B_toDef);
			// Message to 'vVector691_marginal' from Variable factor
			this.vVector691_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector691_rep_B_toDef, vVectorGaussian230, this.vVector691_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__691_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__691' Forwards messages.
			vdouble__691_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index230 = 0; index230<5622; index230++) {
				vdouble__691_F[index230] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector691_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector691_rep' Forwards messages.
			vVector691_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index230 = 0; index230<5622; index230++) {
				vVector691_rep_F[index230] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian230);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector691_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector691_rep' from Replicate factor
			vVector691_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian230);
			// Message to 'vVector691_rep' from Replicate factor
			vVector691_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector691_rep_B_toDef, vVectorGaussian230, vVector691_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector691_rep_F_index230__AMean'
			Vector[] vVector691_rep_F_index230__AMean = new Vector[5622];
			for(int index230 = 0; index230<5622; index230++) {
				// Message to 'vdouble__691' from InnerProduct factor
				vVector691_rep_F_index230__AMean[index230] = InnerProductOp.AMeanInit(vVector691_rep_F[index230]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector691_rep_F_index230__AVariance'
			PositiveDefiniteMatrix[] vVector691_rep_F_index230__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index230 = 0; index230<5622; index230++) {
				// Message to 'vdouble__691' from InnerProduct factor
				vVector691_rep_F_index230__AVariance[index230] = InnerProductOp.AVarianceInit(vVector691_rep_F[index230]);
				// Message to 'vVector691_rep' from Replicate factor
				vVector691_rep_F[index230] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector691_rep_B[index230], vVector691_rep_F_marginal, index230, vVector691_rep_F[index230]);
			}
			// Create array for 'vdouble__691_marginal' Forwards messages.
			this.vdouble__691_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index230 = 0; index230<5622; index230++) {
				this.vdouble__691_marginal_F[index230] = Gaussian.Uniform();
				// Message to 'vdouble__691' from InnerProduct factor
				vVector691_rep_F_index230__AVariance[index230] = InnerProductOp.AVariance(vVector691_rep_F[index230], vVector691_rep_F_index230__AVariance[index230]);
				// Message to 'vdouble__691' from InnerProduct factor
				vVector691_rep_F_index230__AMean[index230] = InnerProductOp.AMean(vVector691_rep_F[index230], vVector691_rep_F_index230__AVariance[index230], vVector691_rep_F_index230__AMean[index230]);
				// Message to 'vdouble__691' from InnerProduct factor
				vdouble__691_F[index230] = InnerProductOp.InnerProductAverageConditional(vVector691_rep_F_index230__AMean[index230], vVector691_rep_F_index230__AVariance[index230], this.VVector__230[index230]);
				// Message to 'vdouble__691_marginal' from DerivedVariable factor
				this.vdouble__691_marginal_F[index230] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__691_use_B[index230], vdouble__691_F[index230], this.vdouble__691_marginal_F[index230]);
			}
			this.Changed_vVector__230_vdouble__690_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__230' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__230Marginal()
		{
			return this.vVector__230_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__690' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__690Marginal()
		{
			return this.vdouble__690_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector691' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector691Marginal()
		{
			return this.vVector691_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__691' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__691Marginal()
		{
			return this.vdouble__691_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
