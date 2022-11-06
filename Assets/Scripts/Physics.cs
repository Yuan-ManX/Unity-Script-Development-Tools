using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Unity Physics Module
using UnityEngine.Physics;

public class Physics : MonoBehaviour
{
    // Class
    // 1、ArticulationBody：A body that forms part of a Physics articulation.
    public ArticulationBody ArticulationBody;

    // 2、BoxCollider：A box-shaped primitive collider.
    public BoxCollider BoxCollider;
    
    // 3、CapsuleCollider：	A capsule-shaped primitive collider.
    public CapsuleCollider CapsuleCollider;
    
    // 4、CharacterController：A CharacterController allows you to easily do movement constrained by collisions without having to deal with a rigidbody.
    public CharacterController CharacterController;
    
    // 5、CharacterJoint：Character Joints are mainly used for Ragdoll effects.
    public CharacterJoint CharacterJoint;
    
    // 6、Collider：A base class of all colliders.
    public Collider Collider;
    
    // 7、Collision：Describes a collision.
    public Collision Collision;
    
    // 8、ConfigurableJoint：The configurable joint is an extremely flexible joint giving you complete control over rotation and linear motion.
    public ConfigurableJoint ConfigurableJoint;
    
    // 9、ConstantForce：A force applied constantly.
    public ConstantForce ConstantForce;
    
    // 10、ControllerColliderHit：ControllerColliderHit is used by CharacterController.OnControllerColliderHit to give detailed information about the collision and how to deal with it.
    public ControllerColliderHit ControllerColliderHit;
    
    // 11、FixedJoint：The Fixed joint groups together 2 rigidbodies, making them stick together in their bound position.
    public FixedJoint FixedJoint;
    
    // 12、HingeJoint：The HingeJoint groups together 2 rigid bodies, constraining them to move like connected by a hinge.
    public HingeJoint HingeJoint;
    
    // 13、Joint：Joint is the base class for all joints.
    public Joint Joint;
    
    // 14、MeshCollider：A mesh collider allows you to do collision detection between meshes and primitives.
    public MeshCollider MeshCollider;
    
    // 15、PhysicMaterial：Physics material describes how to handle colliding objects (friction, bounciness).
    public PhysicMaterial PhysicMaterial;
    
    // 16、Physics：Global physics properties and helper methods.
    public Physics Physics;
    
    // 17、PhysicsSceneExtensions：Scene extensions to access the underlying physics scene.
    public PhysicsSceneExtensions PhysicsSceneExtensions;
    
    // 18、Rigidbody：Control of an object's position through physics simulation.
    public Rigidbody Rigidbody;
    
    // 19、SphereCollider：A sphere-shaped primitive collider.
    public SphereCollider SphereCollider;
    
    // 20、SpringJoint：The spring joint ties together 2 rigid bodies, spring forces will be automatically applied to keep the object at the given distance.
    public SpringJoint SpringJoint;


    // Struct
    // 1、ArticulationDrive：Drive applies forces and torques to the connected bodies.
    public ArticulationDrive ArticulationDrive;
    
    // 2、ArticulationJacobian：The floating point dense Jacobian matrix of the articulation body hierarchy.
    public ArticulationJacobian ArticulationJacobian;
    
    // 3、ArticulationReducedSpace：Coordinates in reduced space.
    public ArticulationReducedSpace ArticulationReducedSpace;
    
    // 4、BoxcastCommand：Use this struct to set up a box cast command to be performed asynchronously during a job.
    public BoxcastCommand BoxcastCommand;
    
    // 5、CapsulecastCommand：Use this struct to set up a capsule cast command that is performed asynchronously during a job.
    public CapsulecastCommand CapsulecastCommand;
    
    // 6、ContactPoint：Describes a contact point where the collision occurs.
    public ContactPoint ContactPoint;
    
    // 7、JointDrive：How the joint's movement will behave along its local X axis.
    public JointDrive JointDrive;
    
    // 8、JointLimits：JointLimits is used by the HingeJoint to limit the joints angle.
    public JointLimits JointLimits;
    
    // 9、JointMotor：The JointMotor is used to motorize a joint.
    public JointMotor JointMotor;
    
    // 10、JointSpring：JointSpring is used add a spring force to HingeJoint and PhysicMaterial.
    public JointSpring JointSpring;

    // 12、ModifiableMassProperties：Mass-related modifiable properties of a contact pair.
    public ModifiableMassProperties ModifiableMassProperties;
    
    // 13、PhysicsScene：Represents a single instance of a 3D physics Scene.
    public PhysicsScene PhysicsScene;
    
    // 14、RaycastCommand：Struct used to set up a raycast command to be performed asynchronously during a job.
    public RaycastCommand RaycastCommand;
    
    // 15、RaycastHit：Structure used to get information back from a raycast.
    public RaycastHit RaycastHit;
    
    // 16、SoftJointLimit：The limits defined by the CharacterJoint.
    public SoftJointLimit SoftJointLimit;
    
    // 17、SoftJointLimitSpring：The configuration of the spring attached to the joint's limits: linear and angular. Used by CharacterJoint and ConfigurableJoint.
    public SoftJointLimitSpring SoftJointLimitSpring;
    
    // 18、SpherecastCommand：Use this struct to set up a sphere cast command that is performed asynchronously during a job.
    public SpherecastCommand SpherecastCommand;
    
    // 19、WheelFrictionCurve：WheelFrictionCurve is used by the WheelCollider to describe friction properties of the wheel tire.
    public WheelFrictionCurve WheelFrictionCurve;


    // Enumeration
    // 1、ArticulationDofLock：The lock type applied to a particular degree of freedom of an articulation body.
    public ArticulationDofLock ArticulationDofLock;
    
    // 2、ArticulationJointType：The type of the joint that restricts movement of the two connected articulation bodies.
    public ArticulationJointType ArticulationJointType;
    
    // 3、CollisionDetectionMode：The collision detection mode constants used for Rigidbody.collisionDetectionMode.
    public CollisionDetectionMode CollisionDetectionMode;
    
    // 4、CollisionFlags：CollisionFlags is a bitmask returned by CharacterController.Move.
    public CollisionFlags CollisionFlags;
    
    // 5、ConfigurableJointMotion：Constrains movement for a ConfigurableJoint along the 6 axes.
    public ConfigurableJointMotion ConfigurableJointMotion;
    
    // 6、ForceMode：Use ForceMode to specify how to apply a force using Rigidbody.AddForce or ArticulationBody.AddForce.
    public ForceMode ForceMode;
    
    // 7、JointProjectionMode：Determines how to snap physics joints back to its constrained position when it drifts off too much.
    public JointProjectionMode JointProjectionMode;
    
    // 8、MeshColliderCookingOptions：Cooking options that are available with MeshCollider.
    public MeshColliderCookingOptions MeshColliderCookingOptions;
    
    // 9、PhysicMaterialCombine：Describes how physics materials of the colliding objects are combined.
    public PhysicMaterialCombine PhysicMaterialCombine;
    
    // 10、QueryTriggerInteraction：Overrides the global Physics.queriesHitTriggers.
    public QueryTriggerInteraction QueryTriggerInteraction;
    
    // 11、RigidbodyConstraints：Use these flags to constrain motion of Rigidbodies.
    public RigidbodyConstraints RigidbodyConstraints;
    
    // 12、RigidbodyInterpolation：Rigidbody interpolation mode.
    public RigidbodyInterpolation RigidbodyInterpolation;
    
    // 13、RotationDriveMode：Control ConfigurableJoint's rotation with either X & YZ or Slerp Drive.
    public RotationDriveMode RotationDriveMode;

}
