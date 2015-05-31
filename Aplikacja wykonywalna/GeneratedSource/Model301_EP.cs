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
	/// Generated by Infer.NET 2.6.41114.1 at 10:29 on 26 maja 2015.
	/// </remarks>
	public partial class Model301_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__302 property</summary>
		private Vector[] VVector__302;
		/// <summary>Field backing the vdouble__906 property</summary>
		private double[] Vdouble__906;
		/// <summary>The number of iterations last computed by Changed_vVector__302_vdouble__906. Set this to zero to force re-execution of Changed_vVector__302_vdouble__906</summary>
		public int Changed_vVector__302_vdouble__906_iterationsDone;
		public PointMass<Vector[]> vVector__302_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__906_marginal;
		/// <summary>Message to marginal of 'vVector907'</summary>
		public VectorGaussian vVector907_marginal_F;
		/// <summary>Message to marginal of 'vdouble__907'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__907_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__302'</summary>
		public Vector[] vVector__302
		{
			get {
				return this.VVector__302;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__302\'");
				}
				this.VVector__302 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__302_vdouble__906_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__906'</summary>
		public double[] vdouble__906
		{
			get {
				return this.Vdouble__906;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__906\'");
				}
				this.Vdouble__906 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__302_vdouble__906_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__302") {
				return this.vVector__302;
			}
			if (variableName=="vdouble__906") {
				return this.vdouble__906;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__302") {
				this.vVector__302 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__906") {
				this.vdouble__906 = (double[])value;
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
			if (variableName=="vVector__302") {
				return this.VVector__302Marginal();
			}
			if (variableName=="vdouble__906") {
				return this.Vdouble__906Marginal();
			}
			if (variableName=="vVector907") {
				return this.VVector907Marginal();
			}
			if (variableName=="vdouble__907") {
				return this.Vdouble__907Marginal();
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
			this.Changed_vVector__302_vdouble__906();
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

		/// <summary>Computations that depend on the observed value of vVector__302 and vdouble__906</summary>
		private void Changed_vVector__302_vdouble__906()
		{
			if (this.Changed_vVector__302_vdouble__906_iterationsDone==1) {
				return ;
			}
			this.vVector__302_marginal = new PointMass<Vector[]>(this.VVector__302);
			this.vdouble__906_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index302) {
				return Gaussian.Uniform();
			});
			this.vdouble__906_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__906_marginal, this.Vdouble__906);
			// The constant 'vVectorGaussian302'
			VectorGaussian vVectorGaussian302 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector907_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian302);
			// Message from use of 'vdouble__907'
			DistributionStructArray<Gaussian,double> vdouble__907_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__907_use' Backwards messages.
			vdouble__907_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index302 = 0; index302<5622; index302++) {
				vdouble__907_use_B[index302] = Gaussian.Uniform();
				// Message to 'vdouble__907_use' from GaussianFromMeanAndVariance factor
				vdouble__907_use_B[index302] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__906[index302], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector907_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector907_rep' Backwards messages.
			vVector907_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index302 = 0; index302<5622; index302++) {
				vVector907_rep_B[index302] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian302);
				// Message to 'vVector907_rep' from InnerProduct factor
				vVector907_rep_B[index302] = InnerProductOp.AAverageConditional(vdouble__907_use_B[index302], this.VVector__302[index302], vVector907_rep_B[index302]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector907_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector907_rep' from Replicate factor
			vVector907_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian302);
			// Message to 'vVector907_rep' from Replicate factor
			vVector907_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector907_rep_B, vVector907_rep_B_toDef);
			// Message to 'vVector907_marginal' from Variable factor
			this.vVector907_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector907_rep_B_toDef, vVectorGaussian302, this.vVector907_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__907_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__907' Forwards messages.
			vdouble__907_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index302 = 0; index302<5622; index302++) {
				vdouble__907_F[index302] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector907_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector907_rep' Forwards messages.
			vVector907_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index302 = 0; index302<5622; index302++) {
				vVector907_rep_F[index302] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian302);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector907_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector907_rep' from Replicate factor
			vVector907_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian302);
			// Message to 'vVector907_rep' from Replicate factor
			vVector907_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector907_rep_B_toDef, vVectorGaussian302, vVector907_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector907_rep_F_index302__AMean'
			Vector[] vVector907_rep_F_index302__AMean = new Vector[5622];
			for(int index302 = 0; index302<5622; index302++) {
				// Message to 'vdouble__907' from InnerProduct factor
				vVector907_rep_F_index302__AMean[index302] = InnerProductOp.AMeanInit(vVector907_rep_F[index302]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector907_rep_F_index302__AVariance'
			PositiveDefiniteMatrix[] vVector907_rep_F_index302__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index302 = 0; index302<5622; index302++) {
				// Message to 'vdouble__907' from InnerProduct factor
				vVector907_rep_F_index302__AVariance[index302] = InnerProductOp.AVarianceInit(vVector907_rep_F[index302]);
				// Message to 'vVector907_rep' from Replicate factor
				vVector907_rep_F[index302] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector907_rep_B[index302], vVector907_rep_F_marginal, index302, vVector907_rep_F[index302]);
			}
			// Create array for 'vdouble__907_marginal' Forwards messages.
			this.vdouble__907_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index302 = 0; index302<5622; index302++) {
				this.vdouble__907_marginal_F[index302] = Gaussian.Uniform();
				// Message to 'vdouble__907' from InnerProduct factor
				vVector907_rep_F_index302__AVariance[index302] = InnerProductOp.AVariance(vVector907_rep_F[index302], vVector907_rep_F_index302__AVariance[index302]);
				// Message to 'vdouble__907' from InnerProduct factor
				vVector907_rep_F_index302__AMean[index302] = InnerProductOp.AMean(vVector907_rep_F[index302], vVector907_rep_F_index302__AVariance[index302], vVector907_rep_F_index302__AMean[index302]);
				// Message to 'vdouble__907' from InnerProduct factor
				vdouble__907_F[index302] = InnerProductOp.InnerProductAverageConditional(vVector907_rep_F_index302__AMean[index302], vVector907_rep_F_index302__AVariance[index302], this.VVector__302[index302]);
				// Message to 'vdouble__907_marginal' from DerivedVariable factor
				this.vdouble__907_marginal_F[index302] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__907_use_B[index302], vdouble__907_F[index302], this.vdouble__907_marginal_F[index302]);
			}
			this.Changed_vVector__302_vdouble__906_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__302' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__302Marginal()
		{
			return this.vVector__302_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__906' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__906Marginal()
		{
			return this.vdouble__906_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector907' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector907Marginal()
		{
			return this.vVector907_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__907' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__907Marginal()
		{
			return this.vdouble__907_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}