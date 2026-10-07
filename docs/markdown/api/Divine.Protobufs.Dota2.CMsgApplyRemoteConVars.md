# <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars"></a> Class CMsgApplyRemoteConVars

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgApplyRemoteConVars : IMessage<CMsgApplyRemoteConVars>, IEquatable<CMsgApplyRemoteConVars>, IDeepCloneable<CMsgApplyRemoteConVars>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md)

#### Implements

IMessage<CMsgApplyRemoteConVars\>, 
[IEquatable<CMsgApplyRemoteConVars\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgApplyRemoteConVars\>, 
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
[EnumerableExtensions.In<CMsgApplyRemoteConVars\>\(CMsgApplyRemoteConVars, params CMsgApplyRemoteConVars\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars__ctor"></a> CMsgApplyRemoteConVars\(\)

```csharp
public CMsgApplyRemoteConVars()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars__ctor_Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_"></a> CMsgApplyRemoteConVars\(CMsgApplyRemoteConVars\)

```csharp
public CMsgApplyRemoteConVars(CMsgApplyRemoteConVars other)
```

#### Parameters

`other` [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_ConVarsFieldNumber"></a> ConVarsFieldNumber

```csharp
public const int ConVarsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_ConVars"></a> ConVars

```csharp
public RepeatedField<CMsgApplyRemoteConVars.Types.ConVar> ConVars { get; }
```

#### Property Value

 RepeatedField<[CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md).[Types](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.md).[ConVar](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.Types.ConVar.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Parser"></a> Parser

```csharp
public static MessageParser<CMsgApplyRemoteConVars> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Clone"></a> Clone\(\)

```csharp
public CMsgApplyRemoteConVars Clone()
```

#### Returns

 [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_Equals_Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_"></a> Equals\(CMsgApplyRemoteConVars\)

```csharp
public bool Equals(CMsgApplyRemoteConVars other)
```

#### Parameters

`other` [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_MergeFrom_Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_"></a> MergeFrom\(CMsgApplyRemoteConVars\)

```csharp
public void MergeFrom(CMsgApplyRemoteConVars other)
```

#### Parameters

`other` [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgApplyRemoteConVars_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

