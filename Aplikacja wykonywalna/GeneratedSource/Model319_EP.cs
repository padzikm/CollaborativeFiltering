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
	public partial class Model319_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__320 property</summary>
		private Vector[] VVector__320;
		/// <summary>Field backing the vdouble__960 property</summary>
		private double[] Vdouble__960;
		/// <summary>The number of iterations last computed by Changed_vVector__320_vdouble__960. Set this to zero to force re-execution of Changed_vVector__320_vdouble__960</summary>
		public int Changed_vVector__320_vdouble__960_iterationsDone;
		public PointMass<Vector[]> vVector__320_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__960_marginal;
		/// <summary>Message to marginal of 'vVector961'</summary>
		public VectorGaussian vVector961_marginal_F;
		/// <summary>Message to marginal of 'vdouble__961'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__961_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__320'</summary>
		public Vector[] vVector__320
		{
			get {
				return this.VVector__320;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__320\'");
				}
				this.VVector__320 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__320_vdouble__960_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__960'</summary>
		public double[] vdouble__960
		{
			get {
				return this.Vdouble__960;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__960\'");
				}
				this.Vdouble__960 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__320_vdouble__960_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__320") {
				return this.vVector__320;
			}
			if (variableName=="vdouble__960") {
				return this.vdouble__960;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__320") {
				this.vVector__320 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__960") {
				this.vdouble__960 = (double[])value;
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
			if (variableName=="vVector__320") {
				return this.VVector__320Marginal();
			}
			if (variableName=="vdouble__960") {
				return this.Vdouble__960Marginal();
			}
			if (variableName=="vVector961") {
				return this.VVector961Marginal();
			}
			if (variableName=="vdouble__961") {
				return this.Vdouble__961Marginal();
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
			this.Changed_vVector__320_vdouble__960();
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

		/// <summary>Computations that depend on the observed value of vVector__320 and vdouble__960</summary>
		private void Changed_vVector__320_vdouble__960()
		{
			if (this.Changed_vVector__320_vdouble__960_iterationsDone==1) {
				return ;
			}
			this.vVector__320_marginal = new PointMass<Vector[]>(this.VVector__320);
			this.vdouble__960_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index320) {
				return Gaussian.Uniform();
			});
			this.vdouble__960_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__960_marginal, this.Vdouble__960);
			// The constant 'vVectorGaussian320'
			VectorGaussian vVectorGaussian320 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector961_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian320);
			// Message from use of 'vdouble__961'
			DistributionStructArray<Gaussian,double> vdouble__961_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__961_use' Backwards messages.
			vdouble__961_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index320 = 0; index320<5622; index320++) {
				vdouble__961_use_B[index320] = Gaussian.Uniform();
				// Message to 'vdouble__961_use' from GaussianFromMeanAndVariance factor
				vdouble__961_use_B[index320] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__960[index320], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector961_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector961_rep' Backwards messages.
			vVector961_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index320 = 0; index320<5622; index320++) {
				vVector961_rep_B[index320] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian320);
				// Message to 'vVector961_rep' from InnerProduct factor
				vVector961_rep_B[index320] = InnerProductOp.AAverageConditional(vdouble__961_use_B[index320], this.VVector__320[index320], vVector961_rep_B[index320]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector961_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector961_rep' from Replicate factor
			vVector961_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian320);
			// Message to 'vVector961_rep' from Replicate factor
			vVector961_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector961_rep_B, vVector961_rep_B_toDef);
			// Message to 'vVector961_marginal' from Variable factor
			this.vVector961_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector961_rep_B_toDef, vVectorGaussian320, this.vVector961_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__961_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__961' Forwards messages.
			vdouble__961_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index320 = 0; index320<5622; index320++) {
				vdouble__961_F[index320] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector961_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector961_rep' Forwards messages.
			vVector961_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index320 = 0; index320<5622; index320++) {
				vVector961_rep_F[index320] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian320);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector961_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector961_rep' from Replicate factor
			vVector961_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian320);
			// Message to 'vVector961_rep' from Replicate factor
			vVector961_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector961_rep_B_toDef, vVectorGaussian320, vVector961_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector961_rep_F_index320__AMean'
			Vector[] vVector961_rep_F_index320__AMean = new Vector[5622];
			for(int index320 = 0; index320<5622; index320++) {
				// Message to 'vdouble__961' from InnerProduct factor
				vVector961_rep_F_index320__AMean[index320] = InnerProductOp.AMeanInit(vVector961_rep_F[index320]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector961_rep_F_index320__AVariance'
			PositiveDefiniteMatrix[] vVector961_rep_F_index320__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index320 = 0; index320<5622; index320++) {
				// Message to 'vdouble__961' from InnerProduct factor
				vVector961_rep_F_index320__AVariance[index320] = InnerProductOp.AVarianceInit(vVector961_rep_F[index320]);
				// Message to 'vVector961_rep' from Replicate factor
				vVector961_rep_F[index320] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector961_rep_B[index320], vVector961_rep_F_marginal, index320, vVector961_rep_F[index320]);
			}
			// Create array for 'vdouble__961_marginal' Forwards messages.
			this.vdouble__961_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index320 = 0; index320<5622; index320++) {
				this.vdouble__961_marginal_F[index320] = Gaussian.Uniform();
				// Message to 'vdouble__961' from InnerProduct factor
				vVector961_rep_F_index320__AVariance[index320] = InnerProductOp.AVariance(vVector961_rep_F[index320], vVector961_rep_F_index320__AVariance[index320]);
				// Message to 'vdouble__961' from InnerProduct factor
				vVector961_rep_F_index320__AMean[index320] = InnerProductOp.AMean(vVector961_rep_F[index320], vVector961_rep_F_index320__AVariance[index320], vVector961_rep_F_index320__AMean[index320]);
				// Message to 'vdouble__961' from InnerProduct factor
				vdouble__961_F[index320] = InnerProductOp.InnerProductAverageConditional(vVector961_rep_F_index320__AMean[index320], vVector961_rep_F_index320__AVariance[index320], this.VVector__320[index320]);
				// Message to 'vdouble__961_marginal' from DerivedVariable factor
				this.vdouble__961_marginal_F[index320] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__961_use_B[index320], vdouble__961_F[index320], this.vdouble__961_marginal_F[index320]);
			}
			this.Changed_vVector__320_vdouble__960_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__320' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__320Marginal()
		{
			return this.vVector__320_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__960' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__960Marginal()
		{
			return this.vdouble__960_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector961' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector961Marginal()
		{
			return this.vVector961_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__961' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__961Marginal()
		{
			return this.vdouble__961_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}