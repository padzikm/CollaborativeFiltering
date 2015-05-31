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
	public partial class Model123_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__124 property</summary>
		private Vector[] VVector__124;
		/// <summary>Field backing the vdouble__372 property</summary>
		private double[] Vdouble__372;
		/// <summary>The number of iterations last computed by Changed_vVector__124_vdouble__372. Set this to zero to force re-execution of Changed_vVector__124_vdouble__372</summary>
		public int Changed_vVector__124_vdouble__372_iterationsDone;
		public PointMass<Vector[]> vVector__124_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__372_marginal;
		/// <summary>Message to marginal of 'vVector373'</summary>
		public VectorGaussian vVector373_marginal_F;
		/// <summary>Message to marginal of 'vdouble__373'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__373_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__124'</summary>
		public Vector[] vVector__124
		{
			get {
				return this.VVector__124;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__124\'");
				}
				this.VVector__124 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__124_vdouble__372_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__372'</summary>
		public double[] vdouble__372
		{
			get {
				return this.Vdouble__372;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__372\'");
				}
				this.Vdouble__372 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__124_vdouble__372_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__124") {
				return this.vVector__124;
			}
			if (variableName=="vdouble__372") {
				return this.vdouble__372;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__124") {
				this.vVector__124 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__372") {
				this.vdouble__372 = (double[])value;
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
			if (variableName=="vVector__124") {
				return this.VVector__124Marginal();
			}
			if (variableName=="vdouble__372") {
				return this.Vdouble__372Marginal();
			}
			if (variableName=="vVector373") {
				return this.VVector373Marginal();
			}
			if (variableName=="vdouble__373") {
				return this.Vdouble__373Marginal();
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
			this.Changed_vVector__124_vdouble__372();
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

		/// <summary>Computations that depend on the observed value of vVector__124 and vdouble__372</summary>
		private void Changed_vVector__124_vdouble__372()
		{
			if (this.Changed_vVector__124_vdouble__372_iterationsDone==1) {
				return ;
			}
			this.vVector__124_marginal = new PointMass<Vector[]>(this.VVector__124);
			this.vdouble__372_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index124) {
				return Gaussian.Uniform();
			});
			this.vdouble__372_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__372_marginal, this.Vdouble__372);
			// The constant 'vVectorGaussian124'
			VectorGaussian vVectorGaussian124 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector373_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian124);
			// Message from use of 'vdouble__373'
			DistributionStructArray<Gaussian,double> vdouble__373_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__373_use' Backwards messages.
			vdouble__373_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index124 = 0; index124<5622; index124++) {
				vdouble__373_use_B[index124] = Gaussian.Uniform();
				// Message to 'vdouble__373_use' from GaussianFromMeanAndVariance factor
				vdouble__373_use_B[index124] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__372[index124], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector373_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector373_rep' Backwards messages.
			vVector373_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index124 = 0; index124<5622; index124++) {
				vVector373_rep_B[index124] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian124);
				// Message to 'vVector373_rep' from InnerProduct factor
				vVector373_rep_B[index124] = InnerProductOp.AAverageConditional(vdouble__373_use_B[index124], this.VVector__124[index124], vVector373_rep_B[index124]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector373_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector373_rep' from Replicate factor
			vVector373_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian124);
			// Message to 'vVector373_rep' from Replicate factor
			vVector373_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector373_rep_B, vVector373_rep_B_toDef);
			// Message to 'vVector373_marginal' from Variable factor
			this.vVector373_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector373_rep_B_toDef, vVectorGaussian124, this.vVector373_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__373_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__373' Forwards messages.
			vdouble__373_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index124 = 0; index124<5622; index124++) {
				vdouble__373_F[index124] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector373_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector373_rep' Forwards messages.
			vVector373_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index124 = 0; index124<5622; index124++) {
				vVector373_rep_F[index124] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian124);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector373_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector373_rep' from Replicate factor
			vVector373_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian124);
			// Message to 'vVector373_rep' from Replicate factor
			vVector373_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector373_rep_B_toDef, vVectorGaussian124, vVector373_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector373_rep_F_index124__AMean'
			Vector[] vVector373_rep_F_index124__AMean = new Vector[5622];
			for(int index124 = 0; index124<5622; index124++) {
				// Message to 'vdouble__373' from InnerProduct factor
				vVector373_rep_F_index124__AMean[index124] = InnerProductOp.AMeanInit(vVector373_rep_F[index124]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector373_rep_F_index124__AVariance'
			PositiveDefiniteMatrix[] vVector373_rep_F_index124__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index124 = 0; index124<5622; index124++) {
				// Message to 'vdouble__373' from InnerProduct factor
				vVector373_rep_F_index124__AVariance[index124] = InnerProductOp.AVarianceInit(vVector373_rep_F[index124]);
				// Message to 'vVector373_rep' from Replicate factor
				vVector373_rep_F[index124] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector373_rep_B[index124], vVector373_rep_F_marginal, index124, vVector373_rep_F[index124]);
			}
			// Create array for 'vdouble__373_marginal' Forwards messages.
			this.vdouble__373_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index124 = 0; index124<5622; index124++) {
				this.vdouble__373_marginal_F[index124] = Gaussian.Uniform();
				// Message to 'vdouble__373' from InnerProduct factor
				vVector373_rep_F_index124__AVariance[index124] = InnerProductOp.AVariance(vVector373_rep_F[index124], vVector373_rep_F_index124__AVariance[index124]);
				// Message to 'vdouble__373' from InnerProduct factor
				vVector373_rep_F_index124__AMean[index124] = InnerProductOp.AMean(vVector373_rep_F[index124], vVector373_rep_F_index124__AVariance[index124], vVector373_rep_F_index124__AMean[index124]);
				// Message to 'vdouble__373' from InnerProduct factor
				vdouble__373_F[index124] = InnerProductOp.InnerProductAverageConditional(vVector373_rep_F_index124__AMean[index124], vVector373_rep_F_index124__AVariance[index124], this.VVector__124[index124]);
				// Message to 'vdouble__373_marginal' from DerivedVariable factor
				this.vdouble__373_marginal_F[index124] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__373_use_B[index124], vdouble__373_F[index124], this.vdouble__373_marginal_F[index124]);
			}
			this.Changed_vVector__124_vdouble__372_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__124' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__124Marginal()
		{
			return this.vVector__124_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__372' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__372Marginal()
		{
			return this.vdouble__372_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector373' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector373Marginal()
		{
			return this.vVector373_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__373' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__373Marginal()
		{
			return this.vdouble__373_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}