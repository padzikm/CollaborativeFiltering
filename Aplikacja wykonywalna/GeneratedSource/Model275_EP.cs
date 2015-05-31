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
	public partial class Model275_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__276 property</summary>
		private Vector[] VVector__276;
		/// <summary>Field backing the vdouble__828 property</summary>
		private double[] Vdouble__828;
		/// <summary>The number of iterations last computed by Changed_vVector__276_vdouble__828. Set this to zero to force re-execution of Changed_vVector__276_vdouble__828</summary>
		public int Changed_vVector__276_vdouble__828_iterationsDone;
		public PointMass<Vector[]> vVector__276_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__828_marginal;
		/// <summary>Message to marginal of 'vVector829'</summary>
		public VectorGaussian vVector829_marginal_F;
		/// <summary>Message to marginal of 'vdouble__829'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__829_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__276'</summary>
		public Vector[] vVector__276
		{
			get {
				return this.VVector__276;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__276\'");
				}
				this.VVector__276 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__276_vdouble__828_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__828'</summary>
		public double[] vdouble__828
		{
			get {
				return this.Vdouble__828;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__828\'");
				}
				this.Vdouble__828 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__276_vdouble__828_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__276") {
				return this.vVector__276;
			}
			if (variableName=="vdouble__828") {
				return this.vdouble__828;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__276") {
				this.vVector__276 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__828") {
				this.vdouble__828 = (double[])value;
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
			if (variableName=="vVector__276") {
				return this.VVector__276Marginal();
			}
			if (variableName=="vdouble__828") {
				return this.Vdouble__828Marginal();
			}
			if (variableName=="vVector829") {
				return this.VVector829Marginal();
			}
			if (variableName=="vdouble__829") {
				return this.Vdouble__829Marginal();
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
			this.Changed_vVector__276_vdouble__828();
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

		/// <summary>Computations that depend on the observed value of vVector__276 and vdouble__828</summary>
		private void Changed_vVector__276_vdouble__828()
		{
			if (this.Changed_vVector__276_vdouble__828_iterationsDone==1) {
				return ;
			}
			this.vVector__276_marginal = new PointMass<Vector[]>(this.VVector__276);
			this.vdouble__828_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index276) {
				return Gaussian.Uniform();
			});
			this.vdouble__828_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__828_marginal, this.Vdouble__828);
			// The constant 'vVectorGaussian276'
			VectorGaussian vVectorGaussian276 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector829_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian276);
			// Message from use of 'vdouble__829'
			DistributionStructArray<Gaussian,double> vdouble__829_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__829_use' Backwards messages.
			vdouble__829_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index276 = 0; index276<5622; index276++) {
				vdouble__829_use_B[index276] = Gaussian.Uniform();
				// Message to 'vdouble__829_use' from GaussianFromMeanAndVariance factor
				vdouble__829_use_B[index276] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__828[index276], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector829_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector829_rep' Backwards messages.
			vVector829_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index276 = 0; index276<5622; index276++) {
				vVector829_rep_B[index276] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian276);
				// Message to 'vVector829_rep' from InnerProduct factor
				vVector829_rep_B[index276] = InnerProductOp.AAverageConditional(vdouble__829_use_B[index276], this.VVector__276[index276], vVector829_rep_B[index276]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector829_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector829_rep' from Replicate factor
			vVector829_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian276);
			// Message to 'vVector829_rep' from Replicate factor
			vVector829_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector829_rep_B, vVector829_rep_B_toDef);
			// Message to 'vVector829_marginal' from Variable factor
			this.vVector829_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector829_rep_B_toDef, vVectorGaussian276, this.vVector829_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__829_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__829' Forwards messages.
			vdouble__829_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index276 = 0; index276<5622; index276++) {
				vdouble__829_F[index276] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector829_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector829_rep' Forwards messages.
			vVector829_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index276 = 0; index276<5622; index276++) {
				vVector829_rep_F[index276] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian276);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector829_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector829_rep' from Replicate factor
			vVector829_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian276);
			// Message to 'vVector829_rep' from Replicate factor
			vVector829_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector829_rep_B_toDef, vVectorGaussian276, vVector829_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector829_rep_F_index276__AMean'
			Vector[] vVector829_rep_F_index276__AMean = new Vector[5622];
			for(int index276 = 0; index276<5622; index276++) {
				// Message to 'vdouble__829' from InnerProduct factor
				vVector829_rep_F_index276__AMean[index276] = InnerProductOp.AMeanInit(vVector829_rep_F[index276]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector829_rep_F_index276__AVariance'
			PositiveDefiniteMatrix[] vVector829_rep_F_index276__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index276 = 0; index276<5622; index276++) {
				// Message to 'vdouble__829' from InnerProduct factor
				vVector829_rep_F_index276__AVariance[index276] = InnerProductOp.AVarianceInit(vVector829_rep_F[index276]);
				// Message to 'vVector829_rep' from Replicate factor
				vVector829_rep_F[index276] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector829_rep_B[index276], vVector829_rep_F_marginal, index276, vVector829_rep_F[index276]);
			}
			// Create array for 'vdouble__829_marginal' Forwards messages.
			this.vdouble__829_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index276 = 0; index276<5622; index276++) {
				this.vdouble__829_marginal_F[index276] = Gaussian.Uniform();
				// Message to 'vdouble__829' from InnerProduct factor
				vVector829_rep_F_index276__AVariance[index276] = InnerProductOp.AVariance(vVector829_rep_F[index276], vVector829_rep_F_index276__AVariance[index276]);
				// Message to 'vdouble__829' from InnerProduct factor
				vVector829_rep_F_index276__AMean[index276] = InnerProductOp.AMean(vVector829_rep_F[index276], vVector829_rep_F_index276__AVariance[index276], vVector829_rep_F_index276__AMean[index276]);
				// Message to 'vdouble__829' from InnerProduct factor
				vdouble__829_F[index276] = InnerProductOp.InnerProductAverageConditional(vVector829_rep_F_index276__AMean[index276], vVector829_rep_F_index276__AVariance[index276], this.VVector__276[index276]);
				// Message to 'vdouble__829_marginal' from DerivedVariable factor
				this.vdouble__829_marginal_F[index276] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__829_use_B[index276], vdouble__829_F[index276], this.vdouble__829_marginal_F[index276]);
			}
			this.Changed_vVector__276_vdouble__828_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__276' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__276Marginal()
		{
			return this.vVector__276_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__828' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__828Marginal()
		{
			return this.vdouble__828_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector829' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector829Marginal()
		{
			return this.vVector829_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__829' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__829Marginal()
		{
			return this.vdouble__829_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}