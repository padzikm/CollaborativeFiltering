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
	public partial class Model173_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vVector__174 property</summary>
		private Vector[] VVector__174;
		/// <summary>Field backing the vdouble__522 property</summary>
		private double[] Vdouble__522;
		/// <summary>The number of iterations last computed by Changed_vVector__174_vdouble__522. Set this to zero to force re-execution of Changed_vVector__174_vdouble__522</summary>
		public int Changed_vVector__174_vdouble__522_iterationsDone;
		public PointMass<Vector[]> vVector__174_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__522_marginal;
		/// <summary>Message to marginal of 'vVector523'</summary>
		public VectorGaussian vVector523_marginal_F;
		/// <summary>Message to marginal of 'vdouble__523'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__523_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector__174'</summary>
		public Vector[] vVector__174
		{
			get {
				return this.VVector__174;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vVector__174\'");
				}
				this.VVector__174 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__174_vdouble__522_iterationsDone = 0;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__522'</summary>
		public double[] vdouble__522
		{
			get {
				return this.Vdouble__522;
			}
			set {
				if ((value!=null)&&(value.Length!=5622)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+5622)+" was expected for variable \'vdouble__522\'");
				}
				this.Vdouble__522 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector__174_vdouble__522_iterationsDone = 0;
			}
		}

		#endregion

		#region Methods
		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector__174") {
				return this.vVector__174;
			}
			if (variableName=="vdouble__522") {
				return this.vdouble__522;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector__174") {
				this.vVector__174 = (Vector[])value;
				return ;
			}
			if (variableName=="vdouble__522") {
				this.vdouble__522 = (double[])value;
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
			if (variableName=="vVector__174") {
				return this.VVector__174Marginal();
			}
			if (variableName=="vdouble__522") {
				return this.Vdouble__522Marginal();
			}
			if (variableName=="vVector523") {
				return this.VVector523Marginal();
			}
			if (variableName=="vdouble__523") {
				return this.Vdouble__523Marginal();
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
			this.Changed_vVector__174_vdouble__522();
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

		/// <summary>Computations that depend on the observed value of vVector__174 and vdouble__522</summary>
		private void Changed_vVector__174_vdouble__522()
		{
			if (this.Changed_vVector__174_vdouble__522_iterationsDone==1) {
				return ;
			}
			this.vVector__174_marginal = new PointMass<Vector[]>(this.VVector__174);
			this.vdouble__522_marginal = new DistributionStructArray<Gaussian,double>(5622, delegate(int index174) {
				return Gaussian.Uniform();
			});
			this.vdouble__522_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__522_marginal, this.Vdouble__522);
			// The constant 'vVectorGaussian174'
			VectorGaussian vVectorGaussian174 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[3] {0.0, 0.0, 0.0}), new PositiveDefiniteMatrix(new double[3, 3] {{1.0, 0.0, 0.0}, {0.0, 1.0, 0.0}, {0.0, 0.0, 1.0}}));
			this.vVector523_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian174);
			// Message from use of 'vdouble__523'
			DistributionStructArray<Gaussian,double> vdouble__523_use_B = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__523_use' Backwards messages.
			vdouble__523_use_B = new DistributionStructArray<Gaussian,double>(5622);
			for(int index174 = 0; index174<5622; index174++) {
				vdouble__523_use_B[index174] = Gaussian.Uniform();
				// Message to 'vdouble__523_use' from GaussianFromMeanAndVariance factor
				vdouble__523_use_B[index174] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__522[index174], 0.1);
			}
			DistributionRefArray<VectorGaussian,Vector> vVector523_rep_B = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector523_rep' Backwards messages.
			vVector523_rep_B = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index174 = 0; index174<5622; index174++) {
				vVector523_rep_B[index174] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian174);
				// Message to 'vVector523_rep' from InnerProduct factor
				vVector523_rep_B[index174] = InnerProductOp.AAverageConditional(vdouble__523_use_B[index174], this.VVector__174[index174], vVector523_rep_B[index174]);
			}
			// Buffer for ReplicateOp_Divide.Marginal<VectorGaussian>
			VectorGaussian vVector523_rep_B_toDef = default(VectorGaussian);
			// Message to 'vVector523_rep' from Replicate factor
			vVector523_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVectorGaussian174);
			// Message to 'vVector523_rep' from Replicate factor
			vVector523_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector523_rep_B, vVector523_rep_B_toDef);
			// Message to 'vVector523_marginal' from Variable factor
			this.vVector523_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector523_rep_B_toDef, vVectorGaussian174, this.vVector523_marginal_F);
			DistributionStructArray<Gaussian,double> vdouble__523_F = default(DistributionStructArray<Gaussian,double>);
			// Create array for 'vdouble__523' Forwards messages.
			vdouble__523_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index174 = 0; index174<5622; index174++) {
				vdouble__523_F[index174] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector523_rep_F = default(DistributionRefArray<VectorGaussian,Vector>);
			// Create array for 'vVector523_rep' Forwards messages.
			vVector523_rep_F = new DistributionRefArray<VectorGaussian,Vector>(5622);
			for(int index174 = 0; index174<5622; index174++) {
				vVector523_rep_F[index174] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian174);
			}
			// Buffer for ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>
			VectorGaussian vVector523_rep_F_marginal = default(VectorGaussian);
			// Message to 'vVector523_rep' from Replicate factor
			vVector523_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVectorGaussian174);
			// Message to 'vVector523_rep' from Replicate factor
			vVector523_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector523_rep_B_toDef, vVectorGaussian174, vVector523_rep_F_marginal);
			// Buffer for InnerProductOp.InnerProductAverageConditional
			// Create array for replicates of 'vVector523_rep_F_index174__AMean'
			Vector[] vVector523_rep_F_index174__AMean = new Vector[5622];
			for(int index174 = 0; index174<5622; index174++) {
				// Message to 'vdouble__523' from InnerProduct factor
				vVector523_rep_F_index174__AMean[index174] = InnerProductOp.AMeanInit(vVector523_rep_F[index174]);
			}
			// Buffer for InnerProductOp.AMean
			// Create array for replicates of 'vVector523_rep_F_index174__AVariance'
			PositiveDefiniteMatrix[] vVector523_rep_F_index174__AVariance = new PositiveDefiniteMatrix[5622];
			for(int index174 = 0; index174<5622; index174++) {
				// Message to 'vdouble__523' from InnerProduct factor
				vVector523_rep_F_index174__AVariance[index174] = InnerProductOp.AVarianceInit(vVector523_rep_F[index174]);
				// Message to 'vVector523_rep' from Replicate factor
				vVector523_rep_F[index174] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector523_rep_B[index174], vVector523_rep_F_marginal, index174, vVector523_rep_F[index174]);
			}
			// Create array for 'vdouble__523_marginal' Forwards messages.
			this.vdouble__523_marginal_F = new DistributionStructArray<Gaussian,double>(5622);
			for(int index174 = 0; index174<5622; index174++) {
				this.vdouble__523_marginal_F[index174] = Gaussian.Uniform();
				// Message to 'vdouble__523' from InnerProduct factor
				vVector523_rep_F_index174__AVariance[index174] = InnerProductOp.AVariance(vVector523_rep_F[index174], vVector523_rep_F_index174__AVariance[index174]);
				// Message to 'vdouble__523' from InnerProduct factor
				vVector523_rep_F_index174__AMean[index174] = InnerProductOp.AMean(vVector523_rep_F[index174], vVector523_rep_F_index174__AVariance[index174], vVector523_rep_F_index174__AMean[index174]);
				// Message to 'vdouble__523' from InnerProduct factor
				vdouble__523_F[index174] = InnerProductOp.InnerProductAverageConditional(vVector523_rep_F_index174__AMean[index174], vVector523_rep_F_index174__AVariance[index174], this.VVector__174[index174]);
				// Message to 'vdouble__523_marginal' from DerivedVariable factor
				this.vdouble__523_marginal_F[index174] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__523_use_B[index174], vdouble__523_F[index174], this.vdouble__523_marginal_F[index174]);
			}
			this.Changed_vVector__174_vdouble__522_iterationsDone = 1;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__174' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__174Marginal()
		{
			return this.vVector__174_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__522' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__522Marginal()
		{
			return this.vdouble__522_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector523' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector523Marginal()
		{
			return this.vVector523_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__523' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__523Marginal()
		{
			return this.vdouble__523_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}