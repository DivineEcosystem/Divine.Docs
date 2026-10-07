# <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount"></a> Class CMsgServerGCUpdateSpectatorCount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerGCUpdateSpectatorCount : IMessage<CMsgServerGCUpdateSpectatorCount>, IEquatable<CMsgServerGCUpdateSpectatorCount>, IDeepCloneable<CMsgServerGCUpdateSpectatorCount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerGCUpdateSpectatorCount](Divine.Protobufs.Dota2.CMsgServerGCUpdateSpectatorCount.md)

#### Implements

IMessage<CMsgServerGCUpdateSpectatorCount\>, 
[IEquatable<CMsgServerGCUpdateSpectatorCount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerGCUpdateSpectatorCount\>, 
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
[EnumerableExtensions.In<CMsgServerGCUpdateSpectatorCount\>\(CMsgServerGCUpdateSpectatorCount, params CMsgServerGCUpdateSpectatorCount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount__ctor"></a> CMsgServerGCUpdateSpectatorCount\(\)

```csharp
public CMsgServerGCUpdateSpectatorCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount__ctor_Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_"></a> CMsgServerGCUpdateSpectatorCount\(CMsgServerGCUpdateSpectatorCount\)

```csharp
public CMsgServerGCUpdateSpectatorCount(CMsgServerGCUpdateSpectatorCount other)
```

#### Parameters

`other` [CMsgServerGCUpdateSpectatorCount](Divine.Protobufs.Dota2.CMsgServerGCUpdateSpectatorCount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_SpectatorCountFieldNumber"></a> SpectatorCountFieldNumber

```csharp
public const int SpectatorCountFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_HasSpectatorCount"></a> HasSpectatorCount

```csharp
public bool HasSpectatorCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerGCUpdateSpectatorCount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerGCUpdateSpectatorCount](Divine.Protobufs.Dota2.CMsgServerGCUpdateSpectatorCount.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_SpectatorCount"></a> SpectatorCount

```csharp
public uint SpectatorCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_ClearSpectatorCount"></a> ClearSpectatorCount\(\)

```csharp
public void ClearSpectatorCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_Clone"></a> Clone\(\)

```csharp
public CMsgServerGCUpdateSpectatorCount Clone()
```

#### Returns

 [CMsgServerGCUpdateSpectatorCount](Divine.Protobufs.Dota2.CMsgServerGCUpdateSpectatorCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_Equals_Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_"></a> Equals\(CMsgServerGCUpdateSpectatorCount\)

```csharp
public bool Equals(CMsgServerGCUpdateSpectatorCount other)
```

#### Parameters

`other` [CMsgServerGCUpdateSpectatorCount](Divine.Protobufs.Dota2.CMsgServerGCUpdateSpectatorCount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_MergeFrom_Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_"></a> MergeFrom\(CMsgServerGCUpdateSpectatorCount\)

```csharp
public void MergeFrom(CMsgServerGCUpdateSpectatorCount other)
```

#### Parameters

`other` [CMsgServerGCUpdateSpectatorCount](Divine.Protobufs.Dota2.CMsgServerGCUpdateSpectatorCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerGCUpdateSpectatorCount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

