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
	public partial class Model111_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__112 property</summary>
		private Vector[] VVector__112;
		/// <summary>Field backing the vdouble__336 property</summary>
		private double[] Vdouble__336;
		/// <summary>The number of iterations last computed by Changed_vVector__112_vdouble__336. Set this to zero to force re-execution of Changed_vVector__112_vdouble__336</summary>
		public int Changed_vVector__112_vdouble__336_iterationsDone;
		public PointMass<Vector[]> vVector__112_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__336_marginal;
		/// <summary>Message to marginal of 'vVector337'</summary>
		public VectorGaussian vVector337_marginal_F;
		/// <summary>Message to marginal of 'vdouble__337'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__337_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__112'</summary>
		public Vector[] vVector__112
		{
			get {
				return this.VVector__112;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__112\'");
				}
				this.VVector__112 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__112_vdouble__336_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__336'</summary>
		public double[] vdouble__336
		{
			get {
				return this.Vdouble__336;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__336\'");
				}
				this.Vdouble__336 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__112_vdouble__336_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__112") {
				return this.vVector__112;
			}
			if (variableName=="vdouble__336") {
				return this.vdouble__336;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__112") {
				this.vVector__112 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__336") {
				this.vdouble__336 = (double[])value;
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
			if (variableName=="vVector__112") {
				return this.VVector__112Marginal();
			}
			if (variableName=="vdouble__336") {
				return this.Vdouble__336Marginal();
			}
			if (variableName=="vVector337") {
				return this.VVector337Marginal();
			}
			if (variableName=="vdouble__337") {
				return this.Vdouble__337Marginal();
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
			this.Changed_vVector__112_vdouble__336();
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

		/// <summary>Computations that depend on the observed value of vVector__112 and vdouble__336</summary>
		private void Changed_vVector__112_vdouble__336()
		{
			if (this.Changed_vVector__112_vdouble__336_iterationsDone==1) {
				return ;
			}
			this.vVector__112_marginal = new PointMass<Vector[]>(this.VVector__112);
			this.vdouble__336_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index112) {
				return Gaussian.Uniform();
			});
			this.vdouble__336_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__336_marginal, this.Vdouble__336);
			// The constant 'vVectorGaussian112'
			VectorGaussian vVectorGaussian112 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector337_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian112);
			// Message from use of 'vdouble__337'
			DistributionStructArray<Gaussian,double> vdouble__337_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__337_use' Backwards messages.
			vdouble__337_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index112 = 0; index112<5622; index112++) {
				vdouble__337_use_B[index112] = Gaussian.Uniform();
				// Message to 'vdouble__337_use' from GaussianFromMeanAndVariance factor
				vdouble__337_use_B[index112] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__336[index112], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector337_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector337_rep' Backwards messages.
			vVector337_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index112 = 0; index112<5622; index112++) {
				vVector337_rep_B[index112] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian112);
				// Message to 'vVector337_rep' from InnerProduct factor
				vVector337_rep_B[index112] = InnerProductOp.AAverageConditional(vdouble__337_use_B[index112], this.VVector__112[index112], vVector337_rep_B[index112]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector337_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector337_rep' from Replicate factor
			vVector337_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian112);
			// Message to 'vVector337_rep' from Replicate factor
			vVector337_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector337_rep_B, vVector337_rep_B_toDef);
			// Message to 'vVector337_marginal' from Variable factor
			this.vVector337_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector337_rep_B_toDef, vVectorGaussian112, this.vVector337_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__337_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__337' Forwards messages.
			vdouble__337_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index112 = 0; index112<5622; index112++) {
				vdouble__337_F[index112] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector337_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector337_rep' Forwards messages.
			vVector337_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index112 = 0; index112<5622; index112++) {
				vVector337_rep_F[index112] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian112);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector337_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector337_rep' from Replicate factor
			vVector337_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian112);
			// Message to 'vVector337_rep' from Replicate factor
			vVector337_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector337_rep_B_toDef, vVectorGaussian112, vVector337_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector337_rep_F_index112__AMean'
			Vector[] vVector337_rep_F_index112__AMean = new Vector[5622];
			for(int index112 = 0; index112<5622; index112++) {
				// Message to 'vdouble__337' from InnerProduct factor
				vVector337_rep_F_index112__AMean[index112] = InnerProductOp.AMeanInit(vVector337_rep_F[index112]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector337_rep_F_index112__AVariance'
			PositiveDefiniteMatrix[] vVector337_rep_F_index112__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index112 = 0; index112<5622; index112++) {
				// Message to 'vdouble__337' from InnerProduct factor
				vVector337_rep_F_index112__AVariance[index112] = InnerProductOp.AVarianceInit(vVector337_rep_F[index112]);
				// Message to 'vVector337_rep' from Replicate factor
				vVector337_rep_F[index112] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector337_rep_B[index112], vVector337_rep_F_marginal, index112, vVector337_rep_F[index112]);
			}
			// Create array for 'vdouble__337_marginal' Forwards messages.
			this.vdouble__337_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index112 = 0; index112<5622; index112++) {
				this.vdouble__337_marginal_F[index112] = Gaussian.Uniform();
				// Message to 'vdouble__337' from InnerProduct factor
				vVector337_rep_F_index112__AVariance[index112] = InnerProductOp.AVariance(vVector337_rep_F[index112], vVector337_rep_F_index112__AVariance[index112]);
				// Message to 'vdouble__337' from InnerProduct factor
				vVector337_rep_F_index112__AMean[index112] = InnerProductOp.AMean(vVector337_rep_F[index112], vVector337_rep_F_index112__AVariance[index112], vVector337_rep_F_index112__AMean[index112]);
				// Message to 'vdouble__337' from InnerProduct factor
				vdouble__337_F[index112] = InnerProductOp.InnerProductAverageConditional(vVector337_rep_F_index112__AMean[index112], vVector337_rep_F_index112__AVariance[index112], this.VVector__112[index112]);
				// Message to 'vdouble__337_marginal' from DerivedVariable factor
				this.vdouble__337_marginal_F[index112] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__337_use_B[index112], vdouble__337_F[index112], this.vdouble__337_marginal_F[index112]);
			}
			this.Changed_vVector__112_vdouble__336_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__112' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__112Marginal()
		{
			return this.vVector__112_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__336' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__336Marginal()
		{
			return this.vdouble__336_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector337' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector337Marginal()
		{
			return this.vVector337_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__337' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__337Marginal()
		{
			return this.vdouble__337_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
