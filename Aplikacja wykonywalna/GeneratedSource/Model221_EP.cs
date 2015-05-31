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
	public partial class Model221_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__222 property</summary>
		private Vector[] VVector__222;
		/// <summary>Field backing the vdouble__666 property</summary>
		private double[] Vdouble__666;
		/// <summary>The number of iterations last computed by Changed_vVector__222_vdouble__666. Set this to zero to force re-execution of Changed_vVector__222_vdouble__666</summary>
		public int Changed_vVector__222_vdouble__666_iterationsDone;
		public PointMass<Vector[]> vVector__222_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__666_marginal;
		/// <summary>Message to marginal of 'vVector667'</summary>
		public VectorGaussian vVector667_marginal_F;
		/// <summary>Message to marginal of 'vdouble__667'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__667_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__222'</summary>
		public Vector[] vVector__222
		{
			get {
				return this.VVector__222;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__222\'");
				}
				this.VVector__222 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__222_vdouble__666_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__666'</summary>
		public double[] vdouble__666
		{
			get {
				return this.Vdouble__666;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__666\'");
				}
				this.Vdouble__666 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__222_vdouble__666_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__222") {
				return this.vVector__222;
			}
			if (variableName=="vdouble__666") {
				return this.vdouble__666;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__222") {
				this.vVector__222 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__666") {
				this.vdouble__666 = (double[])value;
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
			if (variableName=="vVector__222") {
				return this.VVector__222Marginal();
			}
			if (variableName=="vdouble__666") {
				return this.Vdouble__666Marginal();
			}
			if (variableName=="vVector667") {
				return this.VVector667Marginal();
			}
			if (variableName=="vdouble__667") {
				return this.Vdouble__667Marginal();
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
			this.Changed_vVector__222_vdouble__666();
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

		/// <summary>Computations that depend on the observed value of vVector__222 and vdouble__666</summary>
		private void Changed_vVector__222_vdouble__666()
		{
			if (this.Changed_vVector__222_vdouble__666_iterationsDone==1) {
				return ;
			}
			this.vVector__222_marginal = new PointMass<Vector[]>(this.VVector__222);
			this.vdouble__666_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index222) {
				return Gaussian.Uniform();
			});
			this.vdouble__666_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__666_marginal, this.Vdouble__666);
			// The constant 'vVectorGaussian222'
			VectorGaussian vVectorGaussian222 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector667_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian222);
			// Message from use of 'vdouble__667'
			DistributionStructArray<Gaussian,double> vdouble__667_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__667_use' Backwards messages.
			vdouble__667_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index222 = 0; index222<5622; index222++) {
				vdouble__667_use_B[index222] = Gaussian.Uniform();
				// Message to 'vdouble__667_use' from GaussianFromMeanAndVariance factor
				vdouble__667_use_B[index222] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__666[index222], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector667_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector667_rep' Backwards messages.
			vVector667_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index222 = 0; index222<5622; index222++) {
				vVector667_rep_B[index222] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian222);
				// Message to 'vVector667_rep' from InnerProduct factor
				vVector667_rep_B[index222] = InnerProductOp.AAverageConditional(vdouble__667_use_B[index222], this.VVector__222[index222], vVector667_rep_B[index222]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector667_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector667_rep' from Replicate factor
			vVector667_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian222);
			// Message to 'vVector667_rep' from Replicate factor
			vVector667_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector667_rep_B, vVector667_rep_B_toDef);
			// Message to 'vVector667_marginal' from Variable factor
			this.vVector667_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector667_rep_B_toDef, vVectorGaussian222, this.vVector667_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__667_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__667' Forwards messages.
			vdouble__667_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index222 = 0; index222<5622; index222++) {
				vdouble__667_F[index222] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector667_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector667_rep' Forwards messages.
			vVector667_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index222 = 0; index222<5622; index222++) {
				vVector667_rep_F[index222] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian222);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector667_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector667_rep' from Replicate factor
			vVector667_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian222);
			// Message to 'vVector667_rep' from Replicate factor
			vVector667_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector667_rep_B_toDef, vVectorGaussian222, vVector667_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector667_rep_F_index222__AMean'
			Vector[] vVector667_rep_F_index222__AMean = new Vector[5622];
			for(int index222 = 0; index222<5622; index222++) {
				// Message to 'vdouble__667' from InnerProduct factor
				vVector667_rep_F_index222__AMean[index222] = InnerProductOp.AMeanInit(vVector667_rep_F[index222]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector667_rep_F_index222__AVariance'
			PositiveDefiniteMatrix[] vVector667_rep_F_index222__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index222 = 0; index222<5622; index222++) {
				// Message to 'vdouble__667' from InnerProduct factor
				vVector667_rep_F_index222__AVariance[index222] = InnerProductOp.AVarianceInit(vVector667_rep_F[index222]);
				// Message to 'vVector667_rep' from Replicate factor
				vVector667_rep_F[index222] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector667_rep_B[index222], vVector667_rep_F_marginal, index222, vVector667_rep_F[index222]);
			}
			// Create array for 'vdouble__667_marginal' Forwards messages.
			this.vdouble__667_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index222 = 0; index222<5622; index222++) {
				this.vdouble__667_marginal_F[index222] = Gaussian.Uniform();
				// Message to 'vdouble__667' from InnerProduct factor
				vVector667_rep_F_index222__AVariance[index222] = InnerProductOp.AVariance(vVector667_rep_F[index222], vVector667_rep_F_index222__AVariance[index222]);
				// Message to 'vdouble__667' from InnerProduct factor
				vVector667_rep_F_index222__AMean[index222] = InnerProductOp.AMean(vVector667_rep_F[index222], vVector667_rep_F_index222__AVariance[index222], vVector667_rep_F_index222__AMean[index222]);
				// Message to 'vdouble__667' from InnerProduct factor
				vdouble__667_F[index222] = InnerProductOp.InnerProductAverageConditional(vVector667_rep_F_index222__AMean[index222], vVector667_rep_F_index222__AVariance[index222], this.VVector__222[index222]);
				// Message to 'vdouble__667_marginal' from DerivedVariable factor
				this.vdouble__667_marginal_F[index222] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__667_use_B[index222], vdouble__667_F[index222], this.vdouble__667_marginal_F[index222]);
			}
			this.Changed_vVector__222_vdouble__666_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__222' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__222Marginal()
		{
			return this.vVector__222_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__666' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__666Marginal()
		{
			return this.vdouble__666_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector667' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector667Marginal()
		{
			return this.vVector667_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__667' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__667Marginal()
		{
			return this.vdouble__667_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}