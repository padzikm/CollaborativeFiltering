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
	public partial class Model184_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__185 property</summary>
		private Vector[] VVector__185;
		/// <summary>The number of iterations last computed by Changed_vVector__185. Set this to zero to force re-execution of Changed_vVector__185</summary>
		public int Changed_vVector__185_iterationsDone;
		public PointMass<Vector[]> vVector__185_marginal;
		/// <summary>Message to marginal of 'vVector555'</summary>
		public VectorGaussian vVector555_marginal_F;
		/// <summary>Message to marginal of 'vdouble__556'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__556_marginal_F;
		/// <summary>Message to marginal of 'vdouble__555'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__555_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__185'</summary>
		public Vector[] vVector__185
		{
			get {
				return this.VVector__185;
			}
			set {
				if ((value!=null)&&(value.Length!=1)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+1)+" was expected for variable \'vVector__185\'");
				}
				this.VVector__185 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__185_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__185") {
				return this.vVector__185;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__185") {
				this.vVector__185 = (Vector[])value;
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
			if (variableName=="vVector__185") {
				return this.VVector__185Marginal();
			}
			if (variableName=="vVector555") {
				return this.VVector555Marginal();
			}
			if (variableName=="vdouble__555") {
				return this.Vdouble__555Marginal();
			}
			if (variableName=="vdouble__556") {
				return this.Vdouble__556Marginal();
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
			this.Changed_vVector__185();
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

		/// <summary>Computations that depend on the observed value of vVector__185</summary>
		private void Changed_vVector__185()
		{
			if (this.Changed_vVector__185_iterationsDone==1) {
				return ;
			}
			this.vVector__185_marginal = new PointMass<Vector[]>(this.VVector__185);
			// The constant 'vVectorGaussian185'
			VectorGaussian vVectorGaussian185 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {1547829870.0, 525077980.0, 200270.0}), new PositiveDefiniteMatrix(new double[3, 3] {{4254590363351.0, 1127383488860.0, 433199230.0}, {1127383488860.0, 482723521821.0, 146764360.0}, {433199230.0, 146764360.0, 56221.0}}));
			this.vVector555_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian185);
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector555_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector555_rep' from Replicate factor
			vVector555_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian185);
			// Message to 'vVector555_marginal' from Variable factor
			this.vVector555_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector555_rep_B_toDef, vVectorGaussian185, this.vVector555_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__555_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__555' Forwards messages.
			vdouble__555_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index185 = 0; index185<1; index185++) {
				vdouble__555_F[index185] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__556_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__556' Forwards messages.
			vdouble__556_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index185 = 0; index185<1; index185++) {
				vdouble__556_F[index185] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector555_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			DistributionRefArray<VectorGaussian,Vector> vVector555_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector555_rep' Forwards messages.
			vVector555_rep_F = new DistributionRefArray<VectorGaussian,Vector>(1);
			// Create array for 'vVector555_rep' Backwards messages.
			vVector555_rep_B = new DistributionRefArray<VectorGaussian,Vector>(1);
			for(int index185 = 0; index185<1; index185++) {
				vVector555_rep_B[index185] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian185);
				vVector555_rep_F[index185] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian185);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector555_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector555_rep' from Replicate factor
			vVector555_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian185);
			// Message to 'vVector555_rep' from Replicate factor
			vVector555_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector555_rep_B_toDef, vVectorGaussian185, vVector555_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector555_rep_F_index185__AMean'
			Vector[] vVector555_rep_F_index185__AMean = new Vector[1];
			for(int index185 = 0; index185<1; index185++) {
				// Message to 'vdouble__556' from InnerProduct factor
				vVector555_rep_F_index185__AMean[index185] = InnerProductOp.AMeanInit(vVector555_rep_F[index185]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector555_rep_F_index185__AVariance'
			PositiveDefiniteMatrix[] vVector555_rep_F_index185__AVariance = new PositiveDefiniteMatrix[1];
			for(int index185 = 0; index185<1; index185++) {
				// Message to 'vdouble__556' from InnerProduct factor
				vVector555_rep_F_index185__AVariance[index185] = InnerProductOp.AVarianceInit(vVector555_rep_F[index185]);
				// Message to 'vVector555_rep' from Replicate factor
				vVector555_rep_F[index185] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector555_rep_B[index185], vVector555_rep_F_marginal, index185, vVector555_rep_F[index185]);
			}
			// Create array for 'vdouble__556_marginal' Forwards messages.
			this.vdouble__556_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index185 = 0; index185<1; index185++) {
				this.vdouble__556_marginal_F[index185] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__556'
			DistributionStructArray<Gaussian,double> vdouble__556_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__556_use' Backwards messages.
			vdouble__556_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index185 = 0; index185<1; index185++) {
				vdouble__556_use_B[index185] = Gaussian.Uniform();
				// Message to 'vdouble__556' from InnerProduct factor
				vVector555_rep_F_index185__AVariance[index185] = InnerProductOp.AVariance(vVector555_rep_F[index185], vVector555_rep_F_index185__AVariance[index185]);
				// Message to 'vdouble__556' from InnerProduct factor
				vVector555_rep_F_index185__AMean[index185] = InnerProductOp.AMean(vVector555_rep_F[index185], vVector555_rep_F_index185__AVariance[index185], vVector555_rep_F_index185__AMean[index185]);
				// Message to 'vdouble__556' from InnerProduct factor
				vdouble__556_F[index185] = InnerProductOp.InnerProductAverageConditional(vVector555_rep_F_index185__AMean[index185], vVector555_rep_F_index185__AVariance[index185], this.VVector__185[index185]);
				// Message to 'vdouble__556_marginal' from DerivedVariable factor
				this.vdouble__556_marginal_F[index185] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__556_use_B[index185], vdouble__556_F[index185], this.vdouble__556_marginal_F[index185]);
			}
			// Create array for 'vdouble__555_marginal' Forwards messages.
			this.vdouble__555_marginal_F = new DistributionStructArray<Gaussian,double>(1);
			for(int index185 = 0; index185<1; index185++) {
				this.vdouble__555_marginal_F[index185] = Gaussian.Uniform();
			}
			// Message from use of 'vdouble__555'
			DistributionStructArray<Gaussian,double> vdouble__555_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__555_use' Backwards messages.
			vdouble__555_use_B = new DistributionStructArray<Gaussian,double>(1);
			for(int index185 = 0; index185<1; index185++) {
				vdouble__555_use_B[index185] = Gaussian.Uniform();
				// Message to 'vdouble__555' from GaussianFromMeanAndVariance factor
				vdouble__555_F[index185] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__556_F[index185], 0.1);
				// Message to 'vdouble__555_marginal' from Variable factor
				this.vdouble__555_marginal_F[index185] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__555_use_B[index185], vdouble__555_F[index185], this.vdouble__555_marginal_F[index185]);
			}
			this.Changed_vVector__185_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__185' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__185Marginal()
		{
			return this.vVector__185_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector555' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector555Marginal()
		{
			return this.vVector555_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__555' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__555Marginal()
		{
			return this.vdouble__555_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__556' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__556Marginal()
		{
			return this.vdouble__556_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}