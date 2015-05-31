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
	public partial class Model163_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__164 property</summary>
		private Vector[] VVector__164;
		/// <summary>Field backing the vdouble__492 property</summary>
		private double[] Vdouble__492;
		/// <summary>The number of iterations last computed by Changed_vVector__164_vdouble__492. Set this to zero to force re-execution of Changed_vVector__164_vdouble__492</summary>
		public int Changed_vVector__164_vdouble__492_iterationsDone;
		public PointMass<Vector[]> vVector__164_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__492_marginal;
		/// <summary>Message to marginal of 'vVector493'</summary>
		public VectorGaussian vVector493_marginal_F;
		/// <summary>Message to marginal of 'vdouble__493'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__493_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__164'</summary>
		public Vector[] vVector__164
		{
			get {
				return this.VVector__164;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__164\'");
				}
				this.VVector__164 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__164_vdouble__492_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__492'</summary>
		public double[] vdouble__492
		{
			get {
				return this.Vdouble__492;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__492\'");
				}
				this.Vdouble__492 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__164_vdouble__492_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__164") {
				return this.vVector__164;
			}
			if (variableName=="vdouble__492") {
				return this.vdouble__492;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__164") {
				this.vVector__164 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__492") {
				this.vdouble__492 = (double[])value;
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
			if (variableName=="vVector__164") {
				return this.VVector__164Marginal();
			}
			if (variableName=="vdouble__492") {
				return this.Vdouble__492Marginal();
			}
			if (variableName=="vVector493") {
				return this.VVector493Marginal();
			}
			if (variableName=="vdouble__493") {
				return this.Vdouble__493Marginal();
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
			this.Changed_vVector__164_vdouble__492();
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

		/// <summary>Computations that depend on the observed value of vVector__164 and vdouble__492</summary>
		private void Changed_vVector__164_vdouble__492()
		{
			if (this.Changed_vVector__164_vdouble__492_iterationsDone==1) {
				return ;
			}
			this.vVector__164_marginal = new PointMass<Vector[]>(this.VVector__164);
			this.vdouble__492_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index164) {
				return Gaussian.Uniform();
			});
			this.vdouble__492_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__492_marginal, this.Vdouble__492);
			// The constant 'vVectorGaussian164'
			VectorGaussian vVectorGaussian164 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector493_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian164);
			// Message from use of 'vdouble__493'
			DistributionStructArray<Gaussian,double> vdouble__493_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__493_use' Backwards messages.
			vdouble__493_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index164 = 0; index164<5622; index164++) {
				vdouble__493_use_B[index164] = Gaussian.Uniform();
				// Message to 'vdouble__493_use' from GaussianFromMeanAndVariance factor
				vdouble__493_use_B[index164] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__492[index164], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector493_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector493_rep' Backwards messages.
			vVector493_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index164 = 0; index164<5622; index164++) {
				vVector493_rep_B[index164] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian164);
				// Message to 'vVector493_rep' from InnerProduct factor
				vVector493_rep_B[index164] = InnerProductOp.AAverageConditional(vdouble__493_use_B[index164], this.VVector__164[index164], vVector493_rep_B[index164]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector493_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector493_rep' from Replicate factor
			vVector493_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian164);
			// Message to 'vVector493_rep' from Replicate factor
			vVector493_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector493_rep_B, vVector493_rep_B_toDef);
			// Message to 'vVector493_marginal' from Variable factor
			this.vVector493_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector493_rep_B_toDef, vVectorGaussian164, this.vVector493_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__493_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__493' Forwards messages.
			vdouble__493_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index164 = 0; index164<5622; index164++) {
				vdouble__493_F[index164] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector493_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector493_rep' Forwards messages.
			vVector493_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index164 = 0; index164<5622; index164++) {
				vVector493_rep_F[index164] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian164);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector493_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector493_rep' from Replicate factor
			vVector493_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian164);
			// Message to 'vVector493_rep' from Replicate factor
			vVector493_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector493_rep_B_toDef, vVectorGaussian164, vVector493_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector493_rep_F_index164__AMean'
			Vector[] vVector493_rep_F_index164__AMean = new Vector[5622];
			for(int index164 = 0; index164<5622; index164++) {
				// Message to 'vdouble__493' from InnerProduct factor
				vVector493_rep_F_index164__AMean[index164] = InnerProductOp.AMeanInit(vVector493_rep_F[index164]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector493_rep_F_index164__AVariance'
			PositiveDefiniteMatrix[] vVector493_rep_F_index164__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index164 = 0; index164<5622; index164++) {
				// Message to 'vdouble__493' from InnerProduct factor
				vVector493_rep_F_index164__AVariance[index164] = InnerProductOp.AVarianceInit(vVector493_rep_F[index164]);
				// Message to 'vVector493_rep' from Replicate factor
				vVector493_rep_F[index164] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector493_rep_B[index164], vVector493_rep_F_marginal, index164, vVector493_rep_F[index164]);
			}
			// Create array for 'vdouble__493_marginal' Forwards messages.
			this.vdouble__493_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index164 = 0; index164<5622; index164++) {
				this.vdouble__493_marginal_F[index164] = Gaussian.Uniform();
				// Message to 'vdouble__493' from InnerProduct factor
				vVector493_rep_F_index164__AVariance[index164] = InnerProductOp.AVariance(vVector493_rep_F[index164], vVector493_rep_F_index164__AVariance[index164]);
				// Message to 'vdouble__493' from InnerProduct factor
				vVector493_rep_F_index164__AMean[index164] = InnerProductOp.AMean(vVector493_rep_F[index164], vVector493_rep_F_index164__AVariance[index164], vVector493_rep_F_index164__AMean[index164]);
				// Message to 'vdouble__493' from InnerProduct factor
				vdouble__493_F[index164] = InnerProductOp.InnerProductAverageConditional(vVector493_rep_F_index164__AMean[index164], vVector493_rep_F_index164__AVariance[index164], this.VVector__164[index164]);
				// Message to 'vdouble__493_marginal' from DerivedVariable factor
				this.vdouble__493_marginal_F[index164] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__493_use_B[index164], vdouble__493_F[index164], this.vdouble__493_marginal_F[index164]);
			}
			this.Changed_vVector__164_vdouble__492_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__164' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__164Marginal()
		{
			return this.vVector__164_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__492' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__492Marginal()
		{
			return this.vdouble__492_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector493' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector493Marginal()
		{
			return this.vVector493_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__493' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__493Marginal()
		{
			return this.vdouble__493_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}