﻿// **********************************************************************************************************************
// 
// Copyright (c)2013, YoYo Games Ltd. All Rights reserved.
// 
// File:			block_info.cs
// Created:			10/11/2013
// Author:			Mike
// Project:			TileBuilder
// Description:		A block information structure
// 
// Date				Version		BY		Comment
// ----------------------------------------------------------------------------------------------------------------------
// 10/11/2013		V1.0.0      MJD     1st version
// 
// **********************************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileBuilder.MapCreation
{
    // #############################################################################################
    /// Class:<summary>
    ///       	Holds a block information structure
    ///       </summary>
    // #############################################################################################
    class block_info
    {
        private int[] Faces = new int[6];
        public int Left { get { return Faces[0]; } set { Faces[0] = value; } }
        public int Right { get { return Faces[1]; } set { Faces[1] = value; } }
        public int Top { get { return Faces[2]; } set { Faces[2] = value; } }
        public int Bottom { get { return Faces[3]; } set { Faces[3] = value; } }
        public int Lid { get { return Faces[4]; } set { Faces[4] = value; } }
        public int Base { get { return Faces[5]; } set { Faces[5] = value; } }
        public int Ref;

        public int Flags1 =0;
        public int Flags2 =0;


	    // #############################################################################################
	    /// Property: <summary>
	    ///           	Face access as an array
	    ///           </summary>
	    // #############################################################################################
        public int this[int index]
        {
            get
            {
                return Faces[index];
            }
            set
            {
                Faces[index] = value;
            }
        }

	    // #############################################################################################
	    /// Constructor: <summary>
	    ///              	Create a new block by copying another one - except the Ref.
	    ///              </summary>
	    ///
	    /// In:		<param name="_src">Source block tocopy</param>
	    ///
	    // #############################################################################################
        public block_info(block_info _src)
        {
            Copy(_src);
            Ref = 0;
        }

	    // #############################################################################################
	    /// Function:<summary>
	    ///          	Copy the given block details into this block. Does not effect Ref.
	    ///          </summary>
	    ///
	    /// In:		<param name="_src"></param>
	    ///
	    // #############################################################################################
        public void Copy(block_info _src)
        {
            for (int i = 0; i < 6; i++)
            {
                Faces[i] = _src[i];
            }
            Flags1 = _src.Flags1;
            Flags2 = _src.Flags2;
        }
	    // #############################################################################################
	    /// Constructor: <summary>
        ///              	Create an "empty" block
	    ///              </summary>
	    // #############################################################################################
        public block_info()
        {
            Reset();
        }

	    // #############################################################################################
	    /// Constructor: <summary>
	    ///              	Reset a block back to empty - with no ref
	    ///              </summary>
	    // #############################################################################################
        public void Reset()
        {
            for (int i = 0; i < 6; i++) Faces[i] = -1;
            Flags1 = 0;
            Flags2 = 0;
            Ref = 0;
        }
    }
}