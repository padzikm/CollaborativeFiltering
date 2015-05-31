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
	public partial class Model337_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__338 property</summary>
		private Vector[] VVector__338;
		/// <summary>Field backing the vdouble__1014 property</summary>
		private double[] Vdouble__1014;
		/// <summary>The number of iterations last computed by Changed_vVector__338_vdouble__1014. Set this to zero to force re-execution of Changed_vVector__338_vdouble__1014</summary>
		public int Changed_vVector__338_vdouble__1014_iterationsDone;
		public PointMass<Vector[]> vVector__338_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__1014_marginal;
		/// <summary>Message to marginal of 'vVector1015'</summary>
		public VectorGaussian vVector1015_marginal_F;
		/// <summary>Message to marginal of 'vdouble__1015'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__1015_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__338'</summary>
		public Vector[] vVector__338
		{
			get {
				return this.VVector__338;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__338\'");
				}
				this.VVector__338 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__338_vdouble__1014_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__1014'</summary>
		public double[] vdouble__1014
		{
			get {
				return this.Vdouble__1014;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__1014\'");
				}
				this.Vdouble__1014 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__338_vdouble__1014_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__338") {
				return this.vVector__338;
			}
			if (variableName=="vdouble__1014") {
				return this.vdouble__1014;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__338") {
				this.vVector__338 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__1014") {
				this.vdouble__1014 = (double[])value;
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
			if (variableName=="vVector__338") {
				return this.VVector__338Marginal();
			}
			if (variableName=="vdouble__1014") {
				return this.Vdouble__1014Marginal();
			}
			if (variableName=="vVector1015") {
				return this.VVector1015Marginal();
			}
			if (variableName=="vdouble__1015") {
				return this.Vdouble__1015Marginal();
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
			this.Changed_vVector__338_vdouble__1014();
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

		/// <summary>Computations that depend on the observed value of vVector__338 and vdouble__1014</summary>
		private void Changed_vVector__338_vdouble__1014()
		{
			if (this.Changed_vVector__338_vdouble__1014_iterationsDone==1) {
				return ;
			}
			this.vVector__338_marginal = new PointMass<Vector[]>(this.VVector__338);
			this.vdouble__1014_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index338) {
				return Gaussian.Uniform();
			});
			this.vdouble__1014_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__1014_marginal, this.Vdouble__1014);
			// The constant 'vVectorGaussian338'
			VectorGaussian vVectorGaussian338 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector1015_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian338);
			// Message from use of 'vdouble__1015'
			DistributionStructArray<Gaussian,double> vdouble__1015_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__1015_use' Backwards messages.
			vdouble__1015_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index338 = 0; index338<5622; index338++) {
				vdouble__1015_use_B[index338] = Gaussian.Uniform();
				// Message to 'vdouble__1015_use' from GaussianFromMeanAndVariance factor
				vdouble__1015_use_B[index338] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__1014[index338], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector1015_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector1015_rep' Backwards messages.
			vVector1015_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index338 = 0; index338<5622; index338++) {
				vVector1015_rep_B[index338] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian338);
				// Message to 'vVector1015_rep' from InnerProduct factor
				vVector1015_rep_B[index338] = InnerProductOp.AAverageConditional(vdouble__1015_use_B[index338], this.VVector__338[index338], vVector1015_rep_B[index338]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector1015_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector1015_rep' from Replicate factor
			vVector1015_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian338);
			// Message to 'vVector1015_rep' from Replicate factor
			vVector1015_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector1015_rep_B, vVector1015_rep_B_toDef);
			// Message to 'vVector1015_marginal' from Variable factor
			this.vVector1015_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector1015_rep_B_toDef, vVectorGaussian338, this.vVector1015_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__1015_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__1015' Forwards messages.
			vdouble__1015_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index338 = 0; index338<5622; index338++) {
				vdouble__1015_F[index338] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector1015_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector1015_rep' Forwards messages.
			vVector1015_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index338 = 0; index338<5622; index338++) {
				vVector1015_rep_F[index338] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian338);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector1015_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector1015_rep' from Replicate factor
			vVector1015_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian338);
			// Message to 'vVector1015_rep' from Replicate factor
			vVector1015_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector1015_rep_B_toDef, vVectorGaussian338, vVector1015_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector1015_rep_F_index338__AMean'
			Vector[] vVector1015_rep_F_index338__AMean = new Vector[5622];
			for(int index338 = 0; index338<5622; index338++) {
				// Message to 'vdouble__1015' from InnerProduct factor
				vVector1015_rep_F_index338__AMean[index338] = InnerProductOp.AMeanInit(vVector1015_rep_F[index338]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector1015_rep_F_index338__AVariance'
			PositiveDefiniteMatrix[] vVector1015_rep_F_index338__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index338 = 0; index338<5622; index338++) {
				// Message to 'vdouble__1015' from InnerProduct factor
				vVector1015_rep_F_index338__AVariance[index338] = InnerProductOp.AVarianceInit(vVector1015_rep_F[index338]);
				// Message to 'vVector1015_rep' from Replicate factor
				vVector1015_rep_F[index338] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector1015_rep_B[index338], vVector1015_rep_F_marginal, index338, vVector1015_rep_F[index338]);
			}
			// Create array for 'vdouble__1015_marginal' Forwards messages.
			this.vdouble__1015_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index338 = 0; index338<5622; index338++) {
				this.vdouble__1015_marginal_F[index338] = Gaussian.Uniform();
				// Message to 'vdouble__1015' from InnerProduct factor
				vVector1015_rep_F_index338__AVariance[index338] = InnerProductOp.AVariance(vVector1015_rep_F[index338], vVector1015_rep_F_index338__AVariance[index338]);
				// Message to 'vdouble__1015' from InnerProduct factor
				vVector1015_rep_F_index338__AMean[index338] = InnerProductOp.AMean(vVector1015_rep_F[index338], vVector1015_rep_F_index338__AVariance[index338], vVector1015_rep_F_index338__AMean[index338]);
				// Message to 'vdouble__1015' from InnerProduct factor
				vdouble__1015_F[index338] = InnerProductOp.InnerProductAverageConditional(vVector1015_rep_F_index338__AMean[index338], vVector1015_rep_F_index338__AVariance[index338], this.VVector__338[index338]);
				// Message to 'vdouble__1015_marginal' from DerivedVariable factor
				this.vdouble__1015_marginal_F[index338] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__1015_use_B[index338], vdouble__1015_F[index338], this.vdouble__1015_marginal_F[index338]);
			}
			this.Changed_vVector__338_vdouble__1014_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__338' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__338Marginal()
		{
			return this.vVector__338_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__1014' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__1014Marginal()
		{
			return this.vdouble__1014_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector1015' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector1015Marginal()
		{
			return this.vVector1015_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__1015' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__1015Marginal()
		{
			return this.vdouble__1015_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}