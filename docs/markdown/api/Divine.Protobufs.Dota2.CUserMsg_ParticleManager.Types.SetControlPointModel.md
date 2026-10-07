# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel"></a> Class CUserMsg\_ParticleManager.Types.SetControlPointModel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetControlPointModel : IMessage<CUserMsg_ParticleManager.Types.SetControlPointModel>, IEquatable<CUserMsg_ParticleManager.Types.SetControlPointModel>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetControlPointModel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetControlPointModel](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointModel.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetControlPointModel\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetControlPointModel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetControlPointModel\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetControlPointModel\>\(CUserMsg\_ParticleManager.Types.SetControlPointModel, params CUserMsg\_ParticleManager.Types.SetControlPointModel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel__ctor"></a> SetControlPointModel\(\)

```csharp
public SetControlPointModel()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_"></a> SetControlPointModel\(SetControlPointModel\)

```csharp
public SetControlPointModel(CUserMsg_ParticleManager.Types.SetControlPointModel other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointModel](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointModel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_ControlPointFieldNumber"></a> ControlPointFieldNumber

```csharp
public const int ControlPointFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_ModelNameFieldNumber"></a> ModelNameFieldNumber

```csharp
public const int ModelNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_ControlPoint"></a> ControlPoint

```csharp
public int ControlPoint { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_HasControlPoint"></a> HasControlPoint

```csharp
public bool HasControlPoint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_HasModelName"></a> HasModelName

```csharp
public bool HasModelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_ModelName"></a> ModelName

```csharp
public string ModelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetControlPointModel> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointModel](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointModel.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_ClearControlPoint"></a> ClearControlPoint\(\)

```csharp
public void ClearControlPoint()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_ClearModelName"></a> ClearModelName\(\)

```csharp
public void ClearModelName()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetControlPointModel Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointModel](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointModel.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_"></a> Equals\(SetControlPointModel\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetControlPointModel other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointModel](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointModel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_"></a> MergeFrom\(SetControlPointModel\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetControlPointModel other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointModel](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointModel.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointModel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

