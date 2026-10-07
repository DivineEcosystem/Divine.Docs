# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole"></a> Class CDOTAClientMsg\_PlayerDraftPreferRole

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_PlayerDraftPreferRole : IMessage<CDOTAClientMsg_PlayerDraftPreferRole>, IEquatable<CDOTAClientMsg_PlayerDraftPreferRole>, IDeepCloneable<CDOTAClientMsg_PlayerDraftPreferRole>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_PlayerDraftPreferRole](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferRole.md)

#### Implements

IMessage<CDOTAClientMsg\_PlayerDraftPreferRole\>, 
[IEquatable<CDOTAClientMsg\_PlayerDraftPreferRole\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_PlayerDraftPreferRole\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_PlayerDraftPreferRole\>\(CDOTAClientMsg\_PlayerDraftPreferRole, params CDOTAClientMsg\_PlayerDraftPreferRole\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole__ctor"></a> CDOTAClientMsg\_PlayerDraftPreferRole\(\)

```csharp
public CDOTAClientMsg_PlayerDraftPreferRole()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_"></a> CDOTAClientMsg\_PlayerDraftPreferRole\(CDOTAClientMsg\_PlayerDraftPreferRole\)

```csharp
public CDOTAClientMsg_PlayerDraftPreferRole(CDOTAClientMsg_PlayerDraftPreferRole other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerDraftPreferRole](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferRole.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_DesiredFieldNumber"></a> DesiredFieldNumber

```csharp
public const int DesiredFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_RoleIdxFieldNumber"></a> RoleIdxFieldNumber

```csharp
public const int RoleIdxFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_Desired"></a> Desired

```csharp
public bool Desired { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_HasDesired"></a> HasDesired

```csharp
public bool HasDesired { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_HasRoleIdx"></a> HasRoleIdx

```csharp
public bool HasRoleIdx { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_PlayerDraftPreferRole> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_PlayerDraftPreferRole](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferRole.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_RoleIdx"></a> RoleIdx

```csharp
public int RoleIdx { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_ClearDesired"></a> ClearDesired\(\)

```csharp
public void ClearDesired()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_ClearRoleIdx"></a> ClearRoleIdx\(\)

```csharp
public void ClearRoleIdx()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_PlayerDraftPreferRole Clone()
```

#### Returns

 [CDOTAClientMsg\_PlayerDraftPreferRole](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferRole.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_"></a> Equals\(CDOTAClientMsg\_PlayerDraftPreferRole\)

```csharp
public bool Equals(CDOTAClientMsg_PlayerDraftPreferRole other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerDraftPreferRole](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferRole.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_"></a> MergeFrom\(CDOTAClientMsg\_PlayerDraftPreferRole\)

```csharp
public void MergeFrom(CDOTAClientMsg_PlayerDraftPreferRole other)
```

#### Parameters

`other` [CDOTAClientMsg\_PlayerDraftPreferRole](Divine.Protobufs.Dota2.CDOTAClientMsg\_PlayerDraftPreferRole.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_PlayerDraftPreferRole_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

