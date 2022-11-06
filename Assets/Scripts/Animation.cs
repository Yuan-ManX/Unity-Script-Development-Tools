using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Unity Animation Module
using UnityEngine.Animations;

public class Animation : MonoBehaviour
{
    // Class
    // 1、AimConstraint：Constrains the orientation of an object relative to the position of one or more source objects, such that the object is facing the average position of the sources.
    public AimConstraint AimConstraint;
    
    // 2、Animation：The animation component is used to play back animations.
    public Animation Animation;
    
    // 3、AnimationClip：Stores keyframe based animations.
    public AnimationClip AnimationClip;
    
    // 4、AnimationEvent：AnimationEvent lets you call a script function similar to SendMessage as part of playing back an animation.
    public AnimationClip AnimationClip;
    
    // 5、AnimationPlayableBinding：A PlayableBinding that contains information representing an AnimationPlayableOutput.
    public AnimationPlayableBinding AnimationPlayableBinding;
    
    // 6、AnimationPlayableOutputExtensions：Static class providing experimental extension methods for AnimationPlayableOutput .
    public AnimationPlayableOutputExtensions AnimationPlayableOutputExtensions;
    
    // 7、AnimationPlayableUtilities：Implements high-level utility methods to simplify use of the Playable API with Animations.
    public AnimationPlayableUtilities AnimationPlayableUtilities;
    
    // 8、AnimationSceneHandleUtility：Static class providing utility functions for animation scene handles.
    public AnimationSceneHandleUtility AnimationSceneHandleUtility;
    
    // 9、AnimationState：The AnimationState gives full control over animation blending.
    public AnimationState AnimationState;
    
    // 10、AnimationStreamHandleUtility：Static class providing utility functions for animation stream handles.
    public AnimationStreamHandleUtility AnimationStreamHandleUtility;
    
    // 11、Animator：Interface to control the Mecanim animation system.
    public Animator Animator;
    
    // 12、AnimatorControllerParameter：Used to communicate between scripting and the controller. 
    // Some parameters can be set in scripting and used by the controller, while other parameters are based on Custom Curves in Animation Clips and can be sampled using the scripting API.
    public AnimatorControllerParameter AnimatorControllerParameter;
    
    // 13、AnimatorJobExtensions：Static class providing extension methods for Animator and the animation C# jobs.
    public AnimatorJobExtensions AnimatorJobExtensions;
    
    // 14、AnimatorOverrideController：Interface to control Animator Override Controller.
    public AnimatorOverrideController AnimatorOverrideController;
    
    // 15、AnimatorUtility：Various utilities for animator manipulation.
    public AnimatorUtility AnimatorUtility;
    
    // 16、Avatar：Avatar definition.
    public Avatar Avatar;
    
    // 17、AvatarBuilder：Class to build avatars from user scripts.
    public AvatarBuilder AvatarBuilder;
    
    // 18、AvatarMask：AvatarMask is used to mask out humanoid body parts and transforms.
    public AvatarMask AvatarMask;
    
    // 19、DiscreteEvaluationAttribute：	Use this attribute to indicate that a property will be evaluated as a discrete value during animation playback.
    public DiscreteEvaluationAttribute DiscreteEvaluationAttribute;
    
    // 20、HumanPoseHandler：Use this class to create, read, and write the HumanPose for a humanoid avatar skeleton hierarchy or an avatar pose.
    public HumanPoseHandler HumanPoseHandler;
    
    // 21、HumanTrait：	Details of all the human bone and muscle types defined by Mecanim.
    public HumanTrait HumanTrait;
    
    // 22、LookAtConstraint：Constrains the orientation of an object relative to the position of one or more source objects, such that the object is facing the average position of the sources. 
    // The LookAtConstraint is a simplified AimConstraint typically used with a Camera.
    public LookAtConstraint LookAtConstraint;

    // 23、Motion：Base class for AnimationClips and BlendTrees.
    public Motion Motion;
    
    // 24、NotKeyableAttribute：Use this attribute in a script to mark a property as non-animatable.
    public NotKeyableAttribute NotKeyableAttribute;
    
    // 25、ParentConstraint：Constrains the orientation and translation of an object to one or more source objects. The constrained object behaves as if it is in the hierarchy of the sources.
    public ParentConstraint ParentConstraint;
    
    // 26、PositionConstraint：Constrains the position of an object relative to the position of one or more source objects.
    public PositionConstraint PositionConstraint;
    
    // 27、RotationConstraint：Constrains the rotation of an object relative to the rotation of one or more source objects.
    public RotationConstraint RotationConstraint;
    
    // 27、RuntimeAnimatorController：The runtime representation of the AnimatorController. Use this representation to change the Animator Controller during runtime.
    public RuntimeAnimatorController RuntimeAnimatorController;
    
    // 28、ScaleConstraint：Constrains the scale of an object relative to the scale of one or more source objects.
    public ScaleConstraint ScaleConstraint;
    
    // 29、SharedBetweenAnimatorsAttribute：The SharedBetweenAnimatorsAttribute specifies that this StateMachineBehaviour is instantiated only once and shared by all Animator instances. 
    // This attribute reduces the memory footprint for each controller instance.
    public SharedBetweenAnimatorsAttribute SharedBetweenAnimatorsAttribute;
    
    // 30、StateMachineBehaviour：StateMachineBehaviour is a component that can be added to a state machine state. It's the base class every script on a state derives from.
    public StateMachineBehaviour StateMachineBehaviour;


    // Struct
    // 1、AnimationClipPlayable：A Playable that controls an AnimationClip.
    public AnimationClipPlayable AnimationClipPlayable;
    
    // 2、AnimationHumanStream：The humanoid stream of animation data passed from one Playable to another.
    public AnimationHumanStream AnimationHumanStream;
    
    // 3、AnimationLayerMixerPlayable：An implementation of IPlayable that controls an animation layer mixer.
    public AnimationLayerMixerPlayable AnimationLayerMixerPlayable;
    
    // 4、AnimationMixerPlayable：An implementation of IPlayable that controls an animation mixer.
    public AnimationMixerPlayable AnimationMixerPlayable;
    
    // 5、AnimationPlayableOutput：A IPlayableOutput implementation that connects the PlayableGraph to an Animator in the Scene.
    public AnimationPlayableOutput AnimationPlayableOutput;
    
    // 6、AnimationScriptPlayable：A Playable that can run a custom, multi-threaded animation job.
    public AnimationScriptPlayable AnimationScriptPlayable;
    
    // 7、AnimationStream：The stream of animation data passed from one Playable to another.
    public AnimationStream AnimationStream;
    
    // 8、AnimatorClipInfo：Information about clip being played and blended by the Animator.
    public AnimatorClipInfo AnimatorClipInfo;
    
    // 9、AnimatorControllerPlayable：An implementation of IPlayable that controls an animation RuntimeAnimatorController.
    public AnimatorControllerPlayable AnimatorControllerPlayable;
    
    // 10、AnimatorStateInfo：Information about the current or next state.
    public AnimatorStateInfo AnimatorStateInfo;
    
    // 11、AnimatorTransitionInfo：Information about the current transition.
    public AnimatorTransitionInfo AnimatorTransitionInfo;
    
    // 12、ConstraintSource：Represents a source for the constraint.
    public ConstraintSource ConstraintSource;
    
    // 13、HumanBone：The mapping between a bone in the model and the conceptual bone in the Mecanim human anatomy.
    public HumanBone HumanBone;
    
    // 14、HumanDescription：Class that holds humanoid avatar parameters to pass to the AvatarBuilder.BuildHumanAvatar function.
    public HumanDescription HumanDescription;
    
    // 15、HumanLimit：This class stores the rotation limits that define the muscle for a single human bone.
    public HumanLimit HumanLimit;
    
    // 16、HumanPose：Retargetable humanoid pose.
    public HumanPose HumanPose;
    
    // 17、MatchTargetWeightMask：Use this struct to specify the position and rotation weight mask for Animator.MatchTarget.
    public MatchTargetWeightMask MatchTargetWeightMask;
    
    // 18、MuscleHandle：Handle for a muscle in the AnimationHumanStream.
    public MuscleHandle MuscleHandle;
    
    // 19、PropertySceneHandle：Handle to read a Component property on an object in the Scene.
    public PropertySceneHandle PropertySceneHandle;
    
    // 20、PropertyStreamHandle：Handle for a Component property on an object in the AnimationStream.
    public PropertyStreamHandle PropertyStreamHandle;
    
    // 21、SkeletonBone：Details of the Transform name mapped to the skeleton bone of a model and its default position and rotation in the T-pose.
    public SkeletonBone SkeletonBone;
    
    // 22、TransformSceneHandle：Handle to read position, rotation and scale of an object in the Scene.
    public TransformSceneHandle TransformSceneHandle;
    
    // 23、TransformStreamHandle：Position, rotation and scale of an object in the AnimationStream.
    public TransformStreamHandle TransformStreamHandle;


    // Enumeration
    // 1、AnimationBlendMode：Used by Animation.Play function.
    public AnimationBlendMode AnimationBlendMode;
    
    // 2、AnimationCullingType：This enum controlls culling of Animation component.
    public AnimationCullingType AnimationCullingType;
    
    // 3、AnimationStreamSource：Describes how an AnimationStream is initialized
    public AnimationStreamSource AnimationStreamSource;
    
    // 4、AnimatorControllerParameterType：The type of the parameter.
    public AnimatorControllerParameterType AnimatorControllerParameterType;
    
    // 5、AnimatorCullingMode：Culling mode for the Animator.
    public AnimatorCullingMode AnimatorCullingMode;
    
    // 6、AnimatorRecorderMode：The mode of the Animator's recorder.
    public AnimatorRecorderMode AnimatorRecorderMode;
    
    // 7、AnimatorUpdateMode：The update mode of the Animator.
    public AnimatorUpdateMode AnimatorUpdateMode;
    
    // 8、ArmDof：Enumeration of all the muscles in an arm.
    public ArmDof ArmDof;
    
    // 9、AvatarIKGoal：IK Goal.
    public AvatarIKGoal AvatarIKGoal;
    
    // 10、AvatarIKHint：IK Hint.
    public AvatarIKHint AvatarIKHint;
    
    // 11、AvatarMaskBodyPart：Avatar body part.
    public AvatarMaskBodyPart AvatarMaskBodyPart;
    
    // 12、AvatarTarget：Target.
    public AvatarTarget AvatarTarget;
    
    // 13、Axis：Represents the axes used in 3D space.
    public Axis Axis;
    
    // 14、BodyDof：Enumeration of all the muscles in the body.
    public BodyDof BodyDof;
    
    // 15、CustomStreamPropertyType：The type of custom stream property to create using BindCustomStreamProperty
    public CustomStreamPropertyType CustomStreamPropertyType;
    
    // 16、DurationUnit：Describe the unit of a duration.
    public DurationUnit DurationUnit;
    
    // 17、FingerDof：Enumeration of all the muscles in a finger.
    public FingerDof FingerDof
    
    // 18、HeadDof：Enumeration of all the muscles in the head.
    public HeadDof HeadDof;
    
    // 19、HumanBodyBones：	Human Body Bones.
    public HumanBodyBones HumanBodyBones;
    
    // 20、HumanPartDof：Enumeration of all the parts in a human.
    public HumanPartDof HumanPartDof;
    
    // 21、LegDof：Enumeration of all the muscles in a leg.
    public LegDof LegDof;
    
    // 22、PlayMode：Used by Animation.Play function.
    public PlayMode PlayMode;
    
    // 23、QueueMode：Used by Animation.Play function.
    public QueueMode QueueMode;

}
