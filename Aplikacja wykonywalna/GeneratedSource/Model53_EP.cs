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
	/// Generated by Infer.NET 2.6.41114.1 at 10:26 on 26 maja 2015.
	/// </remarks>
	public partial class Model53_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__54 property</summary>
		private Vector[] VVector__54;
		/// <summary>Field backing the vdouble__162 property</summary>
		private double[] Vdouble__162;
		/// <summary>The number of iterations last computed by Changed_vVector__54_vdouble__162. Set this to zero to force re-execution of Changed_vVector__54_vdouble__162</summary>
		public int Changed_vVector__54_vdouble__162_iterationsDone;
		public PointMass<Vector[]> vVector__54_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__162_marginal;
		/// <summary>Message to marginal of 'vVector163'</summary>
		public VectorGaussian vVector163_marginal_F;
		/// <summary>Message to marginal of 'vdouble__163'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__163_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__54'</summary>
		public Vector[] vVector__54
		{
			get {
				return this.VVector__54;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__54\'");
				}
				this.VVector__54 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__54_vdouble__162_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__162'</summary>
		public double[] vdouble__162
		{
			get {
				return this.Vdouble__162;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__162\'");
				}
				this.Vdouble__162 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__54_vdouble__162_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__54") {
				return this.vVector__54;
			}
			if (variableName=="vdouble__162") {
				return this.vdouble__162;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__54") {
				this.vVector__54 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__162") {
				this.vdouble__162 = (double[])value;
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
			if (variableName=="vVector__54") {
				return this.VVector__54Marginal();
			}
			if (variableName=="vdouble__162") {
				return this.Vdouble__162Marginal();
			}
			if (variableName=="vVector163") {
				return this.VVector163Marginal();
			}
			if (variableName=="vdouble__163") {
				return this.Vdouble__163Marginal();
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
			this.Changed_vVector__54_vdouble__162();
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

		/// <summary>Computations that depend on the observed value of vVector__54 and vdouble__162</summary>
		private void Changed_vVector__54_vdouble__162()
		{
			if (this.Changed_vVector__54_vdouble__162_iterationsDone==1) {
				return ;
			}
			this.vVector__54_marginal = new PointMass<Vector[]>(this.VVector__54);
			this.vdouble__162_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index54) {
				return Gaussian.Uniform();
			});
			this.vdouble__162_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__162_marginal, this.Vdouble__162);
			// The constant 'vVectorGaussian54'
			VectorGaussian vVectorGaussian54 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector163_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian54);
			// Message from use of 'vdouble__163'
			DistributionStructArray<Gaussian,double> vdouble__163_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__163_use' Backwards messages.
			vdouble__163_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index54 = 0; index54<5622; index54++) {
				vdouble__163_use_B[index54] = Gaussian.Uniform();
				// Message to 'vdouble__163_use' from GaussianFromMeanAndVariance factor
				vdouble__163_use_B[index54] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__162[index54], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector163_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector163_rep' Backwards messages.
			vVector163_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index54 = 0; index54<5622; index54++) {
				vVector163_rep_B[index54] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian54);
				// Message to 'vVector163_rep' from InnerProduct factor
				vVector163_rep_B[index54] = InnerProductOp.AAverageConditional(vdouble__163_use_B[index54], this.VVector__54[index54], vVector163_rep_B[index54]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector163_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector163_rep' from Replicate factor
			vVector163_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian54);
			// Message to 'vVector163_rep' from Replicate factor
			vVector163_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector163_rep_B, vVector163_rep_B_toDef);
			// Message to 'vVector163_marginal' from Variable factor
			this.vVector163_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector163_rep_B_toDef, vVectorGaussian54, this.vVector163_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__163_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__163' Forwards messages.
			vdouble__163_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index54 = 0; index54<5622; index54++) {
				vdouble__163_F[index54] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector163_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector163_rep' Forwards messages.
			vVector163_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index54 = 0; index54<5622; index54++) {
				vVector163_rep_F[index54] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian54);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector163_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector163_rep' from Replicate factor
			vVector163_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian54);
			// Message to 'vVector163_rep' from Replicate factor
			vVector163_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector163_rep_B_toDef, vVectorGaussian54, vVector163_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector163_rep_F_index54__AMean'
			Vector[] vVector163_rep_F_index54__AMean = new Vector[5622];
			for(int index54 = 0; index54<5622; index54++) {
				// Message to 'vdouble__163' from InnerProduct factor
				vVector163_rep_F_index54__AMean[index54] = InnerProductOp.AMeanInit(vVector163_rep_F[index54]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector163_rep_F_index54__AVariance'
			PositiveDefiniteMatrix[] vVector163_rep_F_index54__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index54 = 0; index54<5622; index54++) {
				// Message to 'vdouble__163' from InnerProduct factor
				vVector163_rep_F_index54__AVariance[index54] = InnerProductOp.AVarianceInit(vVector163_rep_F[index54]);
				// Message to 'vVector163_rep' from Replicate factor
				vVector163_rep_F[index54] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector163_rep_B[index54], vVector163_rep_F_marginal, index54, vVector163_rep_F[index54]);
			}
			// Create array for 'vdouble__163_marginal' Forwards messages.
			this.vdouble__163_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index54 = 0; index54<5622; index54++) {
				this.vdouble__163_marginal_F[index54] = Gaussian.Uniform();
				// Message to 'vdouble__163' from InnerProduct factor
				vVector163_rep_F_index54__AVariance[index54] = InnerProductOp.AVariance(vVector163_rep_F[index54], vVector163_rep_F_index54__AVariance[index54]);
				// Message to 'vdouble__163' from InnerProduct factor
				vVector163_rep_F_index54__AMean[index54] = InnerProductOp.AMean(vVector163_rep_F[index54], vVector163_rep_F_index54__AVariance[index54], vVector163_rep_F_index54__AMean[index54]);
				// Message to 'vdouble__163' from InnerProduct factor
				vdouble__163_F[index54] = InnerProductOp.InnerProductAverageConditional(vVector163_rep_F_index54__AMean[index54], vVector163_rep_F_index54__AVariance[index54], this.VVector__54[index54]);
				// Message to 'vdouble__163_marginal' from DerivedVariable factor
				this.vdouble__163_marginal_F[index54] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__163_use_B[index54], vdouble__163_F[index54], this.vdouble__163_marginal_F[index54]);
			}
			this.Changed_vVector__54_vdouble__162_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__54' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__54Marginal()
		{
			return this.vVector__54_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__162' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__162Marginal()
		{
			return this.vdouble__162_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector163' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector163Marginal()
		{
			return this.vVector163_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__163' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__163Marginal()
		{
			return this.vdouble__163_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}