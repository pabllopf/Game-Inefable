﻿//------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Hostile.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//------------------------------------------------------------------------------------------
namespace DungeonGenerator.Configuration
{
    using DungeonGenerator.Enum;
    using UnityEngine;

    /// <summary>Hostile enemy of dungeon. </summary>
    [System.Serializable]
    public class Hostile : MonoBehaviour
    {
        /// <summary>The decoration</summary>
        [SerializeField]
        private GameObject prefab = null;

        /// <summary>The box to spawn</summary>
        [SerializeField]
        private Box boxToSpawn = Box.Floor;

        /// <summary>The minimum to spawn</summary>
        [SerializeField]
        [Range(0, 100)]
        private int minToSpawn = 0;

        /// <summary>The maximum to spawn</summary>
        [SerializeField]
        [Range(0, 100)]
        private int maxToSpawn = 0;

        #region Encapsulate Fields

        /// <summary>Gets or sets the prefab.</summary>
        /// <value>The prefab.</value>
        public GameObject Prefab { get => gameObject; set => prefab = value; }

        /// <summary>Gets or sets the box to spawn.</summary>
        /// <value>The box to spawn.</value>
        public Box BoxToSpawn { get => boxToSpawn; set => boxToSpawn = value; }

        /// <summary>Gets or sets the minimum to spawn.</summary>
        /// <value>The minimum to spawn.</value>
        public int MinToSpawn { get => minToSpawn; set => minToSpawn = value; }

        /// <summary>Gets or sets the maximum to spawn.</summary>
        /// <value>The maximum to spawn.</value>
        public int MaxToSpawn { get => maxToSpawn; set => maxToSpawn = value; }

        #endregion
    }
}