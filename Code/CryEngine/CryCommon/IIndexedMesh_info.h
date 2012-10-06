#include "IIndexedMesh.h"

STRUCT_INFO_BEGIN(SMeshTexCoord)
	STRUCT_VAR_INFO(s, TYPE_INFO(float))
	STRUCT_VAR_INFO(t, TYPE_INFO(float))
STRUCT_INFO_END(SMeshTexCoord)

STRUCT_INFO_BEGIN(SMeshColor)
	STRUCT_VAR_INFO(r, TYPE_INFO(uint8))
	STRUCT_VAR_INFO(g, TYPE_INFO(uint8))
	STRUCT_VAR_INFO(b, TYPE_INFO(uint8))
	STRUCT_VAR_INFO(a, TYPE_INFO(uint8))
STRUCT_INFO_END(SMeshColor)

STRUCT_INFO_BEGIN(SMeshFace)
	STRUCT_VAR_INFO(v, TYPE_ARRAY(3, TYPE_INFO(unsigned short)))
	STRUCT_VAR_INFO(t, TYPE_ARRAY(3, TYPE_INFO(unsigned short)))
	STRUCT_VAR_INFO(nSubset, TYPE_INFO(unsigned char))
	STRUCT_VAR_INFO(dwFlags, TYPE_INFO(unsigned char))
STRUCT_INFO_END(SMeshFace)

STRUCT_INFO_BEGIN(SMeshTangents)
	STRUCT_VAR_INFO(Tangent, TYPE_INFO(Vec4sf))
	STRUCT_VAR_INFO(Binormal, TYPE_INFO(Vec4sf))
STRUCT_INFO_END(SMeshTangents)

STRUCT_INFO_BEGIN(SMeshQTangents)
	STRUCT_VAR_INFO(TangentBinormal, TYPE_INFO(Vec4sf))
STRUCT_INFO_END(SMeshQTangents)

STRUCT_INFO_BEGIN(SMeshBoneMapping)
	STRUCT_VAR_INFO(boneIDs, TYPE_INFO(ColorB))
	STRUCT_VAR_INFO(weights, TYPE_INFO(ColorB))
STRUCT_INFO_END(SMeshBoneMapping)

STRUCT_INFO_BEGIN(SMeshShapeDeformation)
	STRUCT_VAR_INFO(thin, TYPE_INFO(Vec3))
	STRUCT_VAR_INFO(fat, TYPE_INFO(Vec3))
	STRUCT_VAR_INFO(index, TYPE_INFO(ColorB))
STRUCT_INFO_END(SMeshShapeDeformation)

STRUCT_INFO_BEGIN(SMeshSHCoeffs)
	STRUCT_VAR_INFO(coeffs, TYPE_ARRAY(8, TYPE_INFO(unsigned char)))
STRUCT_INFO_END(SMeshSHCoeffs)

STRUCT_INFO_BEGIN(SSHDecompressionMat)
	STRUCT_VAR_INFO(offset0, TYPE_ARRAY(4, TYPE_INFO(float)))
	STRUCT_VAR_INFO(offset1, TYPE_ARRAY(4, TYPE_INFO(float)))
	STRUCT_VAR_INFO(scale0, TYPE_ARRAY(4, TYPE_INFO(float)))
	STRUCT_VAR_INFO(scale1, TYPE_ARRAY(4, TYPE_INFO(float)))
STRUCT_INFO_END(SSHDecompressionMat)

