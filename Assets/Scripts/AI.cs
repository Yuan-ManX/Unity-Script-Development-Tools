using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Unity AI Module
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    // Class
    // 1、NavMesh：Singleton class to access the baked NavMesh.
    public NavMesh NavMesh;

    // 2、NavMeshAgent：Navigation mesh agent.
    public NavMeshAgent NavMeshAgent;

    // 3、NavMeshBuilder：Navigation mesh builder interface.
    public NavMeshBuilder NavMeshBuilder;

    // 4、NavMeshData：	Contains and represents NavMesh data.
    public NavMeshData NavMeshData;

    // 5、NavMeshObstacle：	An obstacle for NavMeshAgents to avoid.
    public NavMeshObstacle NavMeshObstacle;

    // 6、NavMeshPath：	A path as calculated by the navigation system.
    public NavMeshPath NavMeshPath;

    // 7、OffMeshLink：	Link allowing movement outside the planar navigation mesh.
    public OffMeshLink OffMeshLink;


    // Struct
    // 1、NavMeshBuildDebugSettings：Specify which of the temporary data generated while building the NavMesh should be retained in memory after the process has completed.
    public NavMeshBuildDebugSettings NavMeshBuildDebugSettings;

    // 2、NavMeshBuildMarkup：The NavMesh build markup allows you to control how certain objects are treated during the NavMesh build process, specifically when collecting sources for building.
    public NavMeshBuildMarkup NavMeshBuildMarkup;
    
    // 3、NavMeshBuildSettings：The NavMeshBuildSettings struct allows you to specify a collection of settings which describe the dimensions and limitations of a particular agent type.
    public NavMeshBuildSettings NavMeshBuildSettings;
    
    // 4、NavMeshBuildSource：The input to the NavMesh builder is a list of NavMesh build sources.
    public NavMeshBuildSource NavMeshBuildSource;
    
    // 5、NavMeshDataInstance：The instance is returned when adding NavMesh data.
    public NavMeshDataInstance NavMeshDataInstance;
    
    // 6、NavMeshHit：Result information for NavMesh queries.
    public NavMeshHit NavMeshHit;
    
    // 7、NavMeshLinkData：Used for runtime manipulation of links connecting polygons of the NavMesh.
    public NavMeshLinkData NavMeshLinkData;
    
    // 8、NavMeshLinkInstance：An instance representing a link available for pathfinding.
    public NavMeshLinkInstance NavMeshLinkInstance;
    
    // 9、NavMeshLocation：A world position that is guaranteed to be on the surface of the NavMesh.
    public NavMeshLocation NavMeshLocation;
    
    // 10、NavMeshQuery：Object used for doing navigation operations in a NavMeshWorld.
    public NavMeshQuery NavMeshQuery;
    
    // 11、NavMeshQueryFilter：Specifies which agent type and areas to consider when searching the NavMesh.
    public NavMeshQueryFilter NavMeshQueryFilter;
    
    // 12、NavMeshTriangulation：Contains data describing a triangulation of a navmesh.
    public NavMeshTriangulation NavMeshTriangulation;
    
    // 13、NavMeshWorld：Assembles together a collection of NavMesh surfaces and links that are used as a whole for performing navigation operations.
    public NavMeshWorld NavMeshWorld;
    
    // 14、OffMeshLinkData：State of OffMeshLink.
    public OffMeshLinkData OffMeshLinkData;
    
    // 15、PolygonId：Represents a compact identifier for the data of a NavMesh node.
    public PolygonId PolygonId;


    // Enumeration
    // 1、NavMeshBuildDebugFlags：Bitmask used for operating with debug data from the NavMesh build process.
    public NavMeshBuildDebugFlags NavMeshBuildDebugFlags;
    
    // 2、NavMeshBuildSourceShape：Used with NavMeshBuildSource to define the shape for building NavMesh.
    public NavMeshBuildSourceShape NavMeshBuildSourceShape;
    
    // 3、NavMeshCollectGeometry：Used for specifying the type of geometry to collect. Used with NavMeshBuilder.CollectSources.
    public NavMeshCollectGeometry NavMeshCollectGeometry;
    
    // 4、NavMeshObstacleShape：Shape of the obstacle.
    public NavMeshObstacleShape NavMeshObstacleShape;
    
    // 5、NavMeshPathStatus：Status of path.
    public NavMeshPathStatus NavMeshPathStatus;
    
    // 6、NavMeshPolyTypes：The types of nodes in the navigation data.
    public NavMeshPolyTypes NavMeshPolyTypes;
    
    // 7、ObstacleAvoidanceType：Level of obstacle avoidance.
    public ObstacleAvoidanceType ObstacleAvoidanceType;
    
    // 8、OffMeshLinkType：Link type specifier.
    public OffMeshLinkType OffMeshLinkType;
    
    // 9、PathQueryStatus：Bit flags representing the resulting state of NavMeshQuery operations.
    public PathQueryStatus PathQueryStatus;

}