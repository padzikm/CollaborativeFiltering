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
	public partial class Model138_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__139 property</summary>
		private Vector[] VVector__139;
		/// <summary>The number of iterations last computed by Changed_vVector__139. Set this to zero to force re-execution of Changed_vVector__139</summary>
		public int Changed_vVector__139_iterationsDone;
		public PointMass<Vector[]> vVector__139_marginal;
		/// <summary>Message to marginal of 'vVector417'</summary>
		public VectorGaussian vVector417_marginal_F;
		/// <summary>Message to marginal of 'vdouble__418'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__418_marginal_F;
		/// <summary>Message to marginal of 'vdouble__417'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__417_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__139'</summary>
		public Vector[] vVector__139
		{
			get {
				return this.VVector__139;
			}
			set {
				if ((value!=null)&&(value.Length!=1)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+1)+" was expected for variable \'vVector__139\'");
				}
				this.VVector__139 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__139_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__139") {
				return this.vVector__139;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__139") {
				this.vVector__139 = (Vector[])value;
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
			if (variableName=="vVector__139") {
				return this.VVector__139Marginal();
			}
			if (variableName=="vVector417") {
				return this.VVector417Marginal();
			}
			if (variableName=="vdouble__417") {
				return this.Vdouble__417Marginal();
			}
			if (variableName=="vdouble__418") {
				return this.Vdouble__418Marginal();
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
			this.Changed_vVector__139();
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

		/// <summary>Computations that depend on the observed value of vVector__139</summary>
		private void Changed_vVector__139()
		{
			if (this.Changed_vVector__139_iterationsDone==1) {
				return ;
			}
			this.vVector__139_marginal = new PointMass<Vector[]>(this.VVector__139);
			// The constant 'vVectorGaussian139'
			VectorGaussian vVectorGaussian139 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {1547829870.0, 525077980.0, 200270.0}), new PositiveDefiniteMatrix(new double[3, 3] {{4254590363351.0, 1127383488860.0, 433199230.0}, {1127383488860.0, 482723521821.0, 146764360.0}, {433199230.0, 146764360.0, 56221.0}}));
			this.vVector417_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian139);
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector417_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector417_rep' from Replicate factor
			vVector417_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian139);
			// Message to 'vVector417_marginal' from Variable factor
			this.vVector417_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector417_rep_B_toDef, vVectorGaussian139, this.vVector417_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__417_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__417' Forwards messages.
			vdouble__417_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index139 = 0; index139<1; index139++) {
				vdouble__417_F[index139] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__418_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__418' Forwards messages.
			vdouble__418_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index139 = 0; index139<1; index139++) {
				vdouble__418_F[index139] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector417_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			DistributionRefArray<VectorGaussian,Vector> vVector417_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector417_rep' Forwards messages.
			vVector417_rep_F = new DistributionRefArray<VectorGaussian,Vector>(1);
			// Create array for 'vVector417_rep' Backwards messages.
			vVector417_rep_B = new DistributionRefArray<VectorGaussian,Vector>(1);
			for(int index139 = 0; index139<1; index139++) {
				vVector417_rep_B[index139] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian139);
				vVector417_rep_F[index139] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian139);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector417_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector417_rep' from Replicate factor
			vVector417_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian139);
			// Message to 'vVector417_rep' from Replicate factor
			vVector417_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector417_rep_B_toDef, vVectorGaussian139, vVector417_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector417_rep_F_index139__AMean'
			Vector[] vVector417_rep_F_index139__AMean = new Vector[1];
			for(int index139 = 0; index139<1; index139++) {
				// Message to 'vdouble__418' from InnerProduct factor
				vVector417_rep_F_index139__AMean[index139] = InnerProductOp.AMeanInit(vVector417_rep_F[index139]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector417_rep_F_index139__AVariance'
			PositiveDefiniteMatrix[] vVector417_rep_F_index139__AVariance = new PositiveDefiniteMatrix[1];
			for(int index139 = 0; index139<1; index139++) {
				// Message to 'vdouble__418' from InnerProduct factor
				vVector417_rep_F_index139__AVariance[index139] = InnerProductOp.AVarianceInit(vVector417_rep_F[index139]);
				// Message to 'vVector417_rep' from Replicate factor
				vVector417_rep_F[index139] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector417_rep_B[index139], vVector417_rep_F_marginal, index139, vVector417_rep_F[index139]);
			}
			// Create array for 'vdouble__418_marginal' Forwards messages.
			this.vdouble__418_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index139 = 0; index139<1; index139++) {
				this.vdouble__418_marginal_F[index139] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__418'
			DistributionStructArray<Gaussian,double> vdouble__418_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__418_use' Backwards messages.
			vdouble__418_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index139 = 0; index139<1; index139++) {
				vdouble__418_use_B[index139] = Gaussian.Uniform();
				// Message to 'vdouble__418' from InnerProduct factor
				vVector417_rep_F_index139__AVariance[index139] = InnerProductOp.AVariance(vVector417_rep_F[index139], vVector417_rep_F_index139__AVariance[index139]);
				// Message to 'vdouble__418' from InnerProduct factor
				vVector417_rep_F_index139__AMean[index139] = InnerProductOp.AMean(vVector417_rep_F[index139], vVector417_rep_F_index139__AVariance[index139], vVector417_rep_F_index139__AMean[index139]);
				// Message to 'vdouble__418' from InnerProduct factor
				vdouble__418_F[index139] = InnerProductOp.InnerProductAverageConditional(vVector417_rep_F_index139__AMean[index139], vVector417_rep_F_index139__AVariance[index139], this.VVector__139[index139]);
				// Message to 'vdouble__418_marginal' from DerivedVariable factor
				this.vdouble__418_marginal_F[index139] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__418_use_B[index139], vdouble__418_F[index139], this.vdouble__418_marginal_F[index139]);
			}
			// Create array for 'vdouble__417_marginal' Forwards messages.
			this.vdouble__417_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index139 = 0; index139<1; index139++) {
				this.vdouble__417_marginal_F[index139] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__417'
			DistributionStructArray<Gaussian,double> vdouble__417_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__417_use' Backwards messages.
			vdouble__417_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index139 = 0; index139<1; index139++) {
				vdouble__417_use_B[index139] = Gaussian.Uniform();
				// Message to 'vdouble__417' from GaussianFromMeanAndVariance factor
				vdouble__417_F[index139] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__418_F[index139], 0.1);
				// Message to 'vdouble__417_marginal' from Variable factor
				this.vdouble__417_marginal_F[index139] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__417_use_B[index139], vdouble__417_F[index139], this.vdouble__417_marginal_F[index139]);
			}
			this.Changed_vVector__139_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__139' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__139Marginal()
		{
			return this.vVector__139_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector417' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector417Marginal()
		{
			return this.vVector417_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__417' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__417Marginal()
		{
			return this.vdouble__417_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__418' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__418Marginal()
		{
			return this.vdouble__418_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}