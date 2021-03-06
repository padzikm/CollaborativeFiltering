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
	public partial class Model249_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__250 property</summary>
		private Vector[] VVector__250;
		/// <summary>Field backing the vdouble__750 property</summary>
		private double[] Vdouble__750;
		/// <summary>The number of iterations last computed by Changed_vVector__250_vdouble__750. Set this to zero to force re-execution of Changed_vVector__250_vdouble__750</summary>
		public int Changed_vVector__250_vdouble__750_iterationsDone;
		public PointMass<Vector[]> vVector__250_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__750_marginal;
		/// <summary>Message to marginal of 'vVector751'</summary>
		public VectorGaussian vVector751_marginal_F;
		/// <summary>Message to marginal of 'vdouble__751'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__751_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__250'</summary>
		public Vector[] vVector__250
		{
			get {
				return this.VVector__250;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__250\'");
				}
				this.VVector__250 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__250_vdouble__750_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__750'</summary>
		public double[] vdouble__750
		{
			get {
				return this.Vdouble__750;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__750\'");
				}
				this.Vdouble__750 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__250_vdouble__750_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__250") {
				return this.vVector__250;
			}
			if (variableName=="vdouble__750") {
				return this.vdouble__750;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__250") {
				this.vVector__250 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__750") {
				this.vdouble__750 = (double[])value;
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
			if (variableName=="vVector__250") {
				return this.VVector__250Marginal();
			}
			if (variableName=="vdouble__750") {
				return this.Vdouble__750Marginal();
			}
			if (variableName=="vVector751") {
				return this.VVector751Marginal();
			}
			if (variableName=="vdouble__751") {
				return this.Vdouble__751Marginal();
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
			this.Changed_vVector__250_vdouble__750();
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

		/// <summary>Computations that depend on the observed value of vVector__250 and vdouble__750</summary>
		private void Changed_vVector__250_vdouble__750()
		{
			if (this.Changed_vVector__250_vdouble__750_iterationsDone==1) {
				return ;
			}
			this.vVector__250_marginal = new PointMass<Vector[]>(this.VVector__250);
			this.vdouble__750_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index250) {
				return Gaussian.Uniform();
			});
			this.vdouble__750_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__750_marginal, this.Vdouble__750);
			// The constant 'vVectorGaussian250'
			VectorGaussian vVectorGaussian250 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector751_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian250);
			// Message from use of 'vdouble__751'
			DistributionStructArray<Gaussian,double> vdouble__751_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__751_use' Backwards messages.
			vdouble__751_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index250 = 0; index250<5622; index250++) {
				vdouble__751_use_B[index250] = Gaussian.Uniform();
				// Message to 'vdouble__751_use' from GaussianFromMeanAndVariance factor
				vdouble__751_use_B[index250] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__750[index250], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector751_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector751_rep' Backwards messages.
			vVector751_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index250 = 0; index250<5622; index250++) {
				vVector751_rep_B[index250] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian250);
				// Message to 'vVector751_rep' from InnerProduct factor
				vVector751_rep_B[index250] = InnerProductOp.AAverageConditional(vdouble__751_use_B[index250], this.VVector__250[index250], vVector751_rep_B[index250]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector751_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector751_rep' from Replicate factor
			vVector751_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian250);
			// Message to 'vVector751_rep' from Replicate factor
			vVector751_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector751_rep_B, vVector751_rep_B_toDef);
			// Message to 'vVector751_marginal' from Variable factor
			this.vVector751_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector751_rep_B_toDef, vVectorGaussian250, this.vVector751_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__751_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__751' Forwards messages.
			vdouble__751_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index250 = 0; index250<5622; index250++) {
				vdouble__751_F[index250] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector751_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector751_rep' Forwards messages.
			vVector751_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index250 = 0; index250<5622; index250++) {
				vVector751_rep_F[index250] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian250);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector751_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector751_rep' from Replicate factor
			vVector751_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian250);
			// Message to 'vVector751_rep' from Replicate factor
			vVector751_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector751_rep_B_toDef, vVectorGaussian250, vVector751_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector751_rep_F_index250__AMean'
			Vector[] vVector751_rep_F_index250__AMean = new Vector[5622];
			for(int index250 = 0; index250<5622; index250++) {
				// Message to 'vdouble__751' from InnerProduct factor
				vVector751_rep_F_index250__AMean[index250] = InnerProductOp.AMeanInit(vVector751_rep_F[index250]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector751_rep_F_index250__AVariance'
			PositiveDefiniteMatrix[] vVector751_rep_F_index250__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index250 = 0; index250<5622; index250++) {
				// Message to 'vdouble__751' from InnerProduct factor
				vVector751_rep_F_index250__AVariance[index250] = InnerProductOp.AVarianceInit(vVector751_rep_F[index250]);
				// Message to 'vVector751_rep' from Replicate factor
				vVector751_rep_F[index250] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector751_rep_B[index250], vVector751_rep_F_marginal, index250, vVector751_rep_F[index250]);
			}
			// Create array for 'vdouble__751_marginal' Forwards messages.
			this.vdouble__751_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index250 = 0; index250<5622; index250++) {
				this.vdouble__751_marginal_F[index250] = Gaussian.Uniform();
				// Message to 'vdouble__751' from InnerProduct factor
				vVector751_rep_F_index250__AVariance[index250] = InnerProductOp.AVariance(vVector751_rep_F[index250], vVector751_rep_F_index250__AVariance[index250]);
				// Message to 'vdouble__751' from InnerProduct factor
				vVector751_rep_F_index250__AMean[index250] = InnerProductOp.AMean(vVector751_rep_F[index250], vVector751_rep_F_index250__AVariance[index250], vVector751_rep_F_index250__AMean[index250]);
				// Message to 'vdouble__751' from InnerProduct factor
				vdouble__751_F[index250] = InnerProductOp.InnerProductAverageConditional(vVector751_rep_F_index250__AMean[index250], vVector751_rep_F_index250__AVariance[index250], this.VVector__250[index250]);
				// Message to 'vdouble__751_marginal' from DerivedVariable factor
				this.vdouble__751_marginal_F[index250] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__751_use_B[index250], vdouble__751_F[index250], this.vdouble__751_marginal_F[index250]);
			}
			this.Changed_vVector__250_vdouble__750_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__250' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__250Marginal()
		{
			return this.vVector__250_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__750' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__750Marginal()
		{
			return this.vdouble__750_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector751' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector751Marginal()
		{
			return this.vVector751_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__751' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__751Marginal()
		{
			return this.vdouble__751_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
