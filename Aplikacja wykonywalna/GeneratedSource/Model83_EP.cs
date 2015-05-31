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
	public partial class Model83_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__84 property</summary>
		private Vector[] VVector__84;
		/// <summary>Field backing the vdouble__252 property</summary>
		private double[] Vdouble__252;
		/// <summary>The number of iterations last computed by Changed_vVector__84_vdouble__252. Set this to zero to force re-execution of Changed_vVector__84_vdouble__252</summary>
		public int Changed_vVector__84_vdouble__252_iterationsDone;
		public PointMass<Vector[]> vVector__84_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__252_marginal;
		/// <summary>Message to marginal of 'vVector253'</summary>
		public VectorGaussian vVector253_marginal_F;
		/// <summary>Message to marginal of 'vdouble__253'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__253_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__84'</summary>
		public Vector[] vVector__84
		{
			get {
				return this.VVector__84;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__84\'");
				}
				this.VVector__84 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__84_vdouble__252_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__252'</summary>
		public double[] vdouble__252
		{
			get {
				return this.Vdouble__252;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__252\'");
				}
				this.Vdouble__252 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__84_vdouble__252_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__84") {
				return this.vVector__84;
			}
			if (variableName=="vdouble__252") {
				return this.vdouble__252;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__84") {
				this.vVector__84 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__252") {
				this.vdouble__252 = (double[])value;
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
			if (variableName=="vVector__84") {
				return this.VVector__84Marginal();
			}
			if (variableName=="vdouble__252") {
				return this.Vdouble__252Marginal();
			}
			if (variableName=="vVector253") {
				return this.VVector253Marginal();
			}
			if (variableName=="vdouble__253") {
				return this.Vdouble__253Marginal();
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
			this.Changed_vVector__84_vdouble__252();
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

		/// <summary>Computations that depend on the observed value of vVector__84 and vdouble__252</summary>
		private void Changed_vVector__84_vdouble__252()
		{
			if (this.Changed_vVector__84_vdouble__252_iterationsDone==1) {
				return ;
			}
			this.vVector__84_marginal = new PointMass<Vector[]>(this.VVector__84);
			this.vdouble__252_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index84) {
				return Gaussian.Uniform();
			});
			this.vdouble__252_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__252_marginal, this.Vdouble__252);
			// The constant 'vVectorGaussian84'
			VectorGaussian vVectorGaussian84 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector253_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian84);
			// Message from use of 'vdouble__253'
			DistributionStructArray<Gaussian,double> vdouble__253_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__253_use' Backwards messages.
			vdouble__253_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index84 = 0; index84<5622; index84++) {
				vdouble__253_use_B[index84] = Gaussian.Uniform();
				// Message to 'vdouble__253_use' from GaussianFromMeanAndVariance factor
				vdouble__253_use_B[index84] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__252[index84], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector253_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector253_rep' Backwards messages.
			vVector253_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index84 = 0; index84<5622; index84++) {
				vVector253_rep_B[index84] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian84);
				// Message to 'vVector253_rep' from InnerProduct factor
				vVector253_rep_B[index84] = InnerProductOp.AAverageConditional(vdouble__253_use_B[index84], this.VVector__84[index84], vVector253_rep_B[index84]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector253_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector253_rep' from Replicate factor
			vVector253_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian84);
			// Message to 'vVector253_rep' from Replicate factor
			vVector253_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector253_rep_B, vVector253_rep_B_toDef);
			// Message to 'vVector253_marginal' from Variable factor
			this.vVector253_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector253_rep_B_toDef, vVectorGaussian84, this.vVector253_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__253_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__253' Forwards messages.
			vdouble__253_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index84 = 0; index84<5622; index84++) {
				vdouble__253_F[index84] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector253_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector253_rep' Forwards messages.
			vVector253_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index84 = 0; index84<5622; index84++) {
				vVector253_rep_F[index84] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian84);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector253_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector253_rep' from Replicate factor
			vVector253_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian84);
			// Message to 'vVector253_rep' from Replicate factor
			vVector253_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector253_rep_B_toDef, vVectorGaussian84, vVector253_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector253_rep_F_index84__AMean'
			Vector[] vVector253_rep_F_index84__AMean = new Vector[5622];
			for(int index84 = 0; index84<5622; index84++) {
				// Message to 'vdouble__253' from InnerProduct factor
				vVector253_rep_F_index84__AMean[index84] = InnerProductOp.AMeanInit(vVector253_rep_F[index84]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector253_rep_F_index84__AVariance'
			PositiveDefiniteMatrix[] vVector253_rep_F_index84__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index84 = 0; index84<5622; index84++) {
				// Message to 'vdouble__253' from InnerProduct factor
				vVector253_rep_F_index84__AVariance[index84] = InnerProductOp.AVarianceInit(vVector253_rep_F[index84]);
				// Message to 'vVector253_rep' from Replicate factor
				vVector253_rep_F[index84] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector253_rep_B[index84], vVector253_rep_F_marginal, index84, vVector253_rep_F[index84]);
			}
			// Create array for 'vdouble__253_marginal' Forwards messages.
			this.vdouble__253_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index84 = 0; index84<5622; index84++) {
				this.vdouble__253_marginal_F[index84] = Gaussian.Uniform();
				// Message to 'vdouble__253' from InnerProduct factor
				vVector253_rep_F_index84__AVariance[index84] = InnerProductOp.AVariance(vVector253_rep_F[index84], vVector253_rep_F_index84__AVariance[index84]);
				// Message to 'vdouble__253' from InnerProduct factor
				vVector253_rep_F_index84__AMean[index84] = InnerProductOp.AMean(vVector253_rep_F[index84], vVector253_rep_F_index84__AVariance[index84], vVector253_rep_F_index84__AMean[index84]);
				// Message to 'vdouble__253' from InnerProduct factor
				vdouble__253_F[index84] = InnerProductOp.InnerProductAverageConditional(vVector253_rep_F_index84__AMean[index84], vVector253_rep_F_index84__AVariance[index84], this.VVector__84[index84]);
				// Message to 'vdouble__253_marginal' from DerivedVariable factor
				this.vdouble__253_marginal_F[index84] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__253_use_B[index84], vdouble__253_F[index84], this.vdouble__253_marginal_F[index84]);
			}
			this.Changed_vVector__84_vdouble__252_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__84' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__84Marginal()
		{
			return this.vVector__84_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__252' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__252Marginal()
		{
			return this.vdouble__252_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector253' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector253Marginal()
		{
			return this.vVector253_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__253' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__253Marginal()
		{
			return this.vdouble__253_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}