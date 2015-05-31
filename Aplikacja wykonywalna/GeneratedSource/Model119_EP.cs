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
	public partial class Model119_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__120 property</summary>
		private Vector[] VVector__120;
		/// <summary>Field backing the vdouble__360 property</summary>
		private double[] Vdouble__360;
		/// <summary>The number of iterations last computed by Changed_vVector__120_vdouble__360. Set this to zero to force re-execution of Changed_vVector__120_vdouble__360</summary>
		public int Changed_vVector__120_vdouble__360_iterationsDone;
		public PointMass<Vector[]> vVector__120_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__360_marginal;
		/// <summary>Message to marginal of 'vVector361'</summary>
		public VectorGaussian vVector361_marginal_F;
		/// <summary>Message to marginal of 'vdouble__361'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__361_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__120'</summary>
		public Vector[] vVector__120
		{
			get {
				return this.VVector__120;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__120\'");
				}
				this.VVector__120 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__120_vdouble__360_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__360'</summary>
		public double[] vdouble__360
		{
			get {
				return this.Vdouble__360;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__360\'");
				}
				this.Vdouble__360 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__120_vdouble__360_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__120") {
				return this.vVector__120;
			}
			if (variableName=="vdouble__360") {
				return this.vdouble__360;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__120") {
				this.vVector__120 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__360") {
				this.vdouble__360 = (double[])value;
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
			if (variableName=="vVector__120") {
				return this.VVector__120Marginal();
			}
			if (variableName=="vdouble__360") {
				return this.Vdouble__360Marginal();
			}
			if (variableName=="vVector361") {
				return this.VVector361Marginal();
			}
			if (variableName=="vdouble__361") {
				return this.Vdouble__361Marginal();
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
			this.Changed_vVector__120_vdouble__360();
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

		/// <summary>Computations that depend on the observed value of vVector__120 and vdouble__360</summary>
		private void Changed_vVector__120_vdouble__360()
		{
			if (this.Changed_vVector__120_vdouble__360_iterationsDone==1) {
				return ;
			}
			this.vVector__120_marginal = new PointMass<Vector[]>(this.VVector__120);
			this.vdouble__360_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index120) {
				return Gaussian.Uniform();
			});
			this.vdouble__360_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__360_marginal, this.Vdouble__360);
			// The constant 'vVectorGaussian120'
			VectorGaussian vVectorGaussian120 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector361_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian120);
			// Message from use of 'vdouble__361'
			DistributionStructArray<Gaussian,double> vdouble__361_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__361_use' Backwards messages.
			vdouble__361_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index120 = 0; index120<5622; index120++) {
				vdouble__361_use_B[index120] = Gaussian.Uniform();
				// Message to 'vdouble__361_use' from GaussianFromMeanAndVariance factor
				vdouble__361_use_B[index120] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__360[index120], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector361_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector361_rep' Backwards messages.
			vVector361_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index120 = 0; index120<5622; index120++) {
				vVector361_rep_B[index120] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian120);
				// Message to 'vVector361_rep' from InnerProduct factor
				vVector361_rep_B[index120] = InnerProductOp.AAverageConditional(vdouble__361_use_B[index120], this.VVector__120[index120], vVector361_rep_B[index120]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector361_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector361_rep' from Replicate factor
			vVector361_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian120);
			// Message to 'vVector361_rep' from Replicate factor
			vVector361_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector361_rep_B, vVector361_rep_B_toDef);
			// Message to 'vVector361_marginal' from Variable factor
			this.vVector361_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector361_rep_B_toDef, vVectorGaussian120, this.vVector361_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__361_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__361' Forwards messages.
			vdouble__361_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index120 = 0; index120<5622; index120++) {
				vdouble__361_F[index120] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector361_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector361_rep' Forwards messages.
			vVector361_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index120 = 0; index120<5622; index120++) {
				vVector361_rep_F[index120] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian120);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector361_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector361_rep' from Replicate factor
			vVector361_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian120);
			// Message to 'vVector361_rep' from Replicate factor
			vVector361_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector361_rep_B_toDef, vVectorGaussian120, vVector361_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector361_rep_F_index120__AMean'
			Vector[] vVector361_rep_F_index120__AMean = new Vector[5622];
			for(int index120 = 0; index120<5622; index120++) {
				// Message to 'vdouble__361' from InnerProduct factor
				vVector361_rep_F_index120__AMean[index120] = InnerProductOp.AMeanInit(vVector361_rep_F[index120]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector361_rep_F_index120__AVariance'
			PositiveDefiniteMatrix[] vVector361_rep_F_index120__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index120 = 0; index120<5622; index120++) {
				// Message to 'vdouble__361' from InnerProduct factor
				vVector361_rep_F_index120__AVariance[index120] = InnerProductOp.AVarianceInit(vVector361_rep_F[index120]);
				// Message to 'vVector361_rep' from Replicate factor
				vVector361_rep_F[index120] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector361_rep_B[index120], vVector361_rep_F_marginal, index120, vVector361_rep_F[index120]);
			}
			// Create array for 'vdouble__361_marginal' Forwards messages.
			this.vdouble__361_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index120 = 0; index120<5622; index120++) {
				this.vdouble__361_marginal_F[index120] = Gaussian.Uniform();
				// Message to 'vdouble__361' from InnerProduct factor
				vVector361_rep_F_index120__AVariance[index120] = InnerProductOp.AVariance(vVector361_rep_F[index120], vVector361_rep_F_index120__AVariance[index120]);
				// Message to 'vdouble__361' from InnerProduct factor
				vVector361_rep_F_index120__AMean[index120] = InnerProductOp.AMean(vVector361_rep_F[index120], vVector361_rep_F_index120__AVariance[index120], vVector361_rep_F_index120__AMean[index120]);
				// Message to 'vdouble__361' from InnerProduct factor
				vdouble__361_F[index120] = InnerProductOp.InnerProductAverageConditional(vVector361_rep_F_index120__AMean[index120], vVector361_rep_F_index120__AVariance[index120], this.VVector__120[index120]);
				// Message to 'vdouble__361_marginal' from DerivedVariable factor
				this.vdouble__361_marginal_F[index120] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__361_use_B[index120], vdouble__361_F[index120], this.vdouble__361_marginal_F[index120]);
			}
			this.Changed_vVector__120_vdouble__360_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__120' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__120Marginal()
		{
			return this.vVector__120_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__360' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__360Marginal()
		{
			return this.vdouble__360_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector361' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector361Marginal()
		{
			return this.vVector361_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__361' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__361Marginal()
		{
			return this.vdouble__361_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}