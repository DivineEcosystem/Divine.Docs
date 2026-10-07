# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData"></a> Class CUserMsg\_ParticleManager.Types.SetVData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetVData : IMessage<CUserMsg_ParticleManager.Types.SetVData>, IEquatable<CUserMsg_ParticleManager.Types.SetVData>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetVData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetVData](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetVData.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetVData\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetVData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetVData\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetVData\>\(CUserMsg\_ParticleManager.Types.SetVData, params CUserMsg\_ParticleManager.Types.SetVData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData__ctor"></a> SetVData\(\)

```csharp
public SetVData()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_"></a> SetVData\(SetVData\)

```csharp
public SetVData(CUserMsg_ParticleManager.Types.SetVData other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetVData](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetVData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_VdataNameFieldNumber"></a> VdataNameFieldNumber

```csharp
public const int VdataNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_HasVdataName"></a> HasVdataName

```csharp
public bool HasVdataName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetVData> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetVData](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetVData.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_VdataName"></a> VdataName

```csharp
public string VdataName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_ClearVdataName"></a> ClearVdataName\(\)

```csharp
public void ClearVdataName()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetVData Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetVData](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetVData.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_"></a> Equals\(SetVData\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetVData other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetVData](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetVData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_"></a> MergeFrom\(SetVData\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetVData other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetVData](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetVData.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetVData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

